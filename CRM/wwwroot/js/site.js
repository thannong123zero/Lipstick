document.addEventListener("DOMContentLoaded", function () {
    // Attach the function to the scroll event
    //document.addEventListener('scroll', checkScrollDirection);
    //Excute setcookei
    SetLanguageByCookie();
});
//Get cookei
function getValueCookie(cname) {
    let name = cname + "=";
    let decodedCookie = decodeURIComponent(document.cookie);
    let ca = decodedCookie.split(';');
    for (let i = 0; i < ca.length; i++) {
        let c = ca[i];
        while (c.charAt(0) == ' ') {
            c = c.substring(1);
        }
        if (c.indexOf(name) == 0) {
            return c.substring(name.length, c.length);
        }
    }
    return null;
}
//Set cookei
function setValueCookie(cname, cvalue, exdays) {
    const d = new Date();
    d.setTime(d.getTime() + (exdays * 24 * 60 * 60 * 1000));
    let expires = "expires=" + d.toUTCString();
    document.cookie = cname + "=" + cvalue + ";" + expires;
}
//Delete cookei
function deleteCookie(name) {
    document.cookie = name + '=; Path=/; Expires=Thu, 01 Jan 1970 00:00:01 GMT;';
}
//Set language by cookie
function SetLanguageByCookie() {
    let cookeiValue = getValueCookie('.AspNetCore.Culture');
    let image = document.getElementById('setLanguageByCookei');
    //let elementMobile = document.getElementById('setLanguageByCookeiMobile');
    if (cookeiValue && cookeiValue.includes('vi-VN')) {
        image.setAttribute("src", "/assets/images/en.png");
        //element.innerText = 'ENG';
        //elementMobile.innerText = 'ENG';
    }
    else if (cookeiValue && cookeiValue.includes('en-US')) {
        image.setAttribute("src", "/assets/images/vn.png");
        //element.innerText = 'VN';
        //elementMobile.innerText = 'VN';
    }
    else {
        image.setAttribute("src", "/assets/images/en.png");
        //element.innerText = 'ENG';
        //elementMobile.innerText = 'ENG';

    }
}
// fucntion open ErrorModel
function openErrorModal(strMessage) {
    var myDiv = document.getElementById("MyModalErrorAlertBody");
    myDiv.innerHTML = strMessage;
    $('#myModalError').modal('show');
}
// fucntion opeN SuccessModel
function openSuccessModal(strMessage) {
    var myDiv = document.getElementById("MyModalSuccessAlertBody");
    myDiv.innerHTML = strMessage;
    $('#myModalSuccess').modal('show');
}
