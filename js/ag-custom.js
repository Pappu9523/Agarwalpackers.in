$(document).ready(function(){
    // tab effect
    //alert();
    $('.marquee-with-options').marquee({
      speed: 10000,
      gap: 50,
      delayBeforeStart: 0,
      direction: 'left',
      duplicated: true,
      pauseOnHover: true
    });
        
    $(".tab-container .contant").hide();												 
    $(".tab-container .contant").each(function()
    {
    var index = $(".tab-container .contant").index( this ) +1;
    $(this).addClass('s' +index);
    })
             
    $(".tab ul li:nth-child(1)").addClass('active');
    $(".tab-container .contant:nth-child(1)").css("display" , "block")
    $(".tab ul li").click(function(){
    var value = $(".tab ul li").index( this ) + 1;
    //alert(value);
    $(".tab ul li").removeClass('active');
    $(this).addClass('active');
    $(".tab-container .contant").hide();
    $(".s" +value).show()
    })
    $( ".tab-container .contant" ).before("<div class='respon'><span class='span'></span></div>")
    $(".tab ul li").each(function(){
    var htm = $(this).text();
    var htmind = $(this).index();
            
    $(".respon").eq(htmind).append(htm)
    
    })
    
    $(".respon > span.span").click(function(){
    
    if($(this).hasClass("active"))
    {
        $(this).parent(".respon").next(".contant").slideUp();
        $(".contant").slideUp(500);
        $(".respon > span.span").removeClass('active');
        $(this).removeClass('active');
    
    }
    else
    {
        $(".contant").slideUp(500);
        $(".respon > span.span").removeClass("active");
        $(this).parent(".respon").next(".contant").slideDown(500);
        $(this).addClass("active");
    
    
    }	})
    
    $(".respon:first-child > .span").addClass("active");
    
    $(document).ready(function(){
    
    $(".client-slider").flexisel({
            visibleItems: 3,
            animationSpeed: 1000,
            autoPlay: false,
            autoPlaySpeed: 9000,            
            pauseOnHover: true,
            enableResponsiveBreakpoints: true,
            responsiveBreakpoints: { 
                portrait: { 
                    changePoint:500,
                    visibleItems: 1
                }, 
                landscape: { 
                    changePoint:650,
                    visibleItems: 2
                },
                tablet: { 
                    changePoint:1000,
                    visibleItems:2
                }
            }
        });
        
    });
    
    $(window).load(function() {
    
        $(".teamslider").flexisel({
            visibleItems: 3,
            animationSpeed: 1000,
            autoPlay: false,
            autoPlaySpeed: 9000,            
            pauseOnHover: true,
            enableResponsiveBreakpoints: true,
            responsiveBreakpoints: { 
                portrait: { 
                    changePoint:500,
                    visibleItems: 2
                }, 
                landscape: { 
                    changePoint:650,
                    visibleItems: 2
                },
                tablet: { 
                    changePoint:1000,
                    visibleItems: 2
                }
            }
        });
        
        $(".stre-slide").flexisel({
            visibleItems: 4,
            animationSpeed: 1000,
            autoPlay: false,
            autoPlaySpeed: 9000,            
            pauseOnHover: true,
            enableResponsiveBreakpoints: true,
            responsiveBreakpoints: { 
                portrait: { 
                    changePoint:500,
                    visibleItems: 2
                }, 
                landscape: { 
                    changePoint:650,
                    visibleItems: 2
                },
                tablet: { 
                    changePoint:1000,
                    visibleItems: 2
                }
            }
        });
        
        $(".core-service-slider").flexisel({
            visibleItems: 1,
            animationSpeed: 1000,
            autoPlay: false,
            autoPlaySpeed: 9000,            
            pauseOnHover: true,
            clone:false,
            enableResponsiveBreakpoints: true,
            responsiveBreakpoints: { 
                portrait: { 
                    changePoint:500,
                    visibleItems: 1
                }, 
                landscape: { 
                    changePoint:650,
                    visibleItems: 1
                },
                tablet: { 
                    changePoint:1000,
                    visibleItems:1
                }
            }
        });
        
        $(".ourclient-slider").flexisel({
            visibleItems: 9,
            animationSpeed: 1000,
            autoPlay: false,
            autoPlaySpeed: 9000,            
            pauseOnHover: true,
            clone:false,
            enableResponsiveBreakpoints: true,
            responsiveBreakpoints: { 
                portrait: { 
                    changePoint:500,
                    visibleItems: 2
                    
                }, 
                landscape: { 
                    changePoint:650,
                    visibleItems:4
                    
                },
                tablet: { 
                    changePoint:1000,
                    visibleItems:5
                    
                }
            }
        });
        
        $(".feature-slider").flexisel({
            visibleItems: 6,
            animationSpeed: 1000,
            autoPlay: false,
            autoPlaySpeed: 9000,            
            pauseOnHover: true,
            clone:false,
            enableResponsiveBreakpoints: true,
            responsiveBreakpoints: { 
                portrait: { 
                    changePoint:500,
                    visibleItems: 2
                    
                }, 
                landscape: { 
                    changePoint:650,
                    visibleItems:3
                    
                },
                tablet: { 
                    changePoint:1000,
                    visibleItems:4
                    
                }
            }
        });
        });
    
    $(".poputext").wrap("<div class='poputext-cover'></div>");
    $(".poputext").append("<div class='pop-close'></div>");
    
    $(".feature-on li img").click(function(){
        //alert();
        $(this).next(".poputext-cover").show();
        
        $(".pop-close").click(function(){
        $(".poputext-cover").hide();
        
        })
    })
    
    
     $('.counter').counterUp({
                delay: 10,
                time: 6000
            });
    
    //
    })