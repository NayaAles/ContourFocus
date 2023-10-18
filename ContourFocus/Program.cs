using ContourFocus;
using OpenQA.Selenium;

var selenium = new Selenium();

ContourFocus.Authorization.Run(selenium);

ContourFocus.ListInput.Add(selenium);
