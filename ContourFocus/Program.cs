using ContourFocus;

var selenium = new Selenium();

ContourFocus.Authorization.Run(selenium);

selenium.GoToUrl(SecureData.Get("LinkListImport"));

