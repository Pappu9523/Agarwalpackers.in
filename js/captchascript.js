function checkform(theform){
    var why = "";
    
    if(theform.CaptchaInput.value == ""){
    why += "- Please Enter CAPTCHA Code.\n";
    }
    if(theform.CaptchaInput.value != ""){
    if(ValidCaptcha(theform.CaptchaInput.value) == false){
    why += "- The CAPTCHA Code Does Not Match.\n";
    }
    }
    if(why != ""){
    alert(why);
    return false;
    }
    }
    
    var a = Math.ceil(Math.random() * 9)+ '';
    var b = Math.ceil(Math.random() * 9)+ '';
    var c = Math.ceil(Math.random() * 9)+ '';
    var d = Math.ceil(Math.random() * 9)+ '';
    var e = Math.ceil(Math.random() * 9)+ '';
    
    var code = a + b + c + d + e;
    document.getElementById("txtCaptcha").value = code;
    document.getElementById("CaptchaDiv").innerHTML = code;
    document.getElementById("CaptchaDiv1").innerHTML = code;
    document.getElementById("CaptchaDiv2").innerHTML = code;
    document.getElementById("CaptchaDiv3").innerHTML = code;
    document.getElementById("CaptchaDiv4").innerHTML = code;
    document.getElementById("CaptchaDiv5").innerHTML = code;
    
    // Validate input against the generated number
    function ValidCaptcha(){
    var str1 = removeSpaces(document.getElementById('txtCaptcha').value);
    var str2 = removeSpaces(document.getElementById('CaptchaInput').value);
    if (str1 == str2){
    return true;
    }else{
    return false;
    }
    }
    
    // Remove the spaces from the entered and generated code
    function removeSpaces(string){
    return string.split(' ').join('');
    }




$(document).ready(function() {
$('#Agarwal-packers-whatsapp-click-tracking').attr('href', 'https://api.whatsapp.com/send/?phone=919360014001&amp;text=I%27m+inquiring+about+shifting&amp;app_absent=0&amp;utm_source=Google+All+Traffic&amp;utm_medium=Whats_APP&amp;utm_id=Whats-App');


});

$(document).ready(function() {
$('#Agarwal-packers-whatsapp-click-tracking').attr('onClick', "ga('send', 'event', 'Whats App Click', 'Click', 'Whats App Click', '1');");
});

$(window).scroll(function(){
    // var offset = $(".moon-menu").offset();
    // var top = offset.top
    // console.log(top);
      if ($(this).scrollTop() > 158) {
          $('.moon-menu').addClass('fixed');
      } else {
          $('.moon-menu').removeClass('fixed');
      }
});