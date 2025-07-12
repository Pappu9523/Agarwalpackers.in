
let button = document.querySelector('.button');
let menu = document.querySelector('#cssmenu ul');

button.addEventListener('click', () => {

    if(menu.style.display == "block") {
        menu.style.display = "none";
    } else {
        menu.style.display = "block";
    }

    button.classList.toggle('menu-opened');
})

let scrollTopButton = document.querySelector("#toTop");

window.onscroll = function() {
    if(document.body.scrollTop > 50 || document.documentElement.scrollTop > 50) {
        scrollTopButton.style.display = "block";
    } else {
        scrollTopButton.style.display = "none";
    }
}

scrollTopButton.addEventListener('click', () => {
    document.body.scrollTop = 0;
    document.documentElement.scrollTop = 0;
})

window.onresize = function() {
    if(window.innerWidth > 1000) {
        menu.style.display = "block";
    } else {
        menu.style.display = "none";
    }
}
