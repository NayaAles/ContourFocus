using ContourFocus;

var selenium = new Selenium();
selenium.GoToUrl(SecureData.Get("BaseLink"));

ContourFocus.Authorization.Run(selenium);


