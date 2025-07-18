var staticCaches = ["alphanumeric"];
function inArray(b, c) {
    return 0 < b.filter(function(a) {
        return a === c
    }).length ? !0 : !1
}
self.addEventListener("install", function(b) {
    console.log("SW: Installed and updated");
    self.skipWaiting()
});
self.addEventListener("activate", function(b) {
    console.log("SW: Activate");
    b.waitUntil(caches.keys().then(function(b) {
        return Promise.all(b.map(function(a) {
            if (!inArray(staticCaches, a))
                return caches.delete(a)
        }))
    }).then(function() {
        console.log("SW: First time caching ...");
        return caches.open(staticCaches).then(function(b) {
            return fetch("/").then(function(a) {
                return a.json()
            }).then(function(a) {
                a = JSON.parse(a);
                a = a.reduce(function(a, b) {
                    /(?:json|html|mobirise)/i.test(b.split(".").pop()) || a.push(b);
                    return a
                }, ["/", "manifest.json"]);
                return Promise.all(a.map(function(a) {
                    return fetch(a, {
                        mode: "no-cors"
                    }).then(function(d) {
                        return b.put(a, d)
                    })
                }))
            })
        }).catch(function(b) {
            // console.error(b)
            console.log(b);
        })
    }))
});
self.addEventListener("fetch", function(b) {
    "http" === b.request.url.slice(0, 4) && b.respondWith(fetch(b.request).then(function(c) {
        if (404 == c.status)
            return new Response("Page not found!");
        var a = c.clone();
        caches.open(staticCaches).then(function(c) {
            0 === b.request.url.indexOf("http") && c.matchAll(b.request, {
                ignoreSearch: !0
            }).then(function(a) {
                return Promise.all(a.map(function(a) {
                    return c.delete(a)
                }))
            })
            // .then(function(value) {
            //     // c.put(b.request, a)
            //     // console.log(value);
            // })
        });
        return c
    }).catch(function(c) {
        console.log("Offline mode.");
        return caches.match(b.request).then(function(a) {
            return a ? a : !1
        })
    }))
});