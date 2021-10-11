$(document).ready(function() {var formatter = new CucumberHTML.DOMFormatter($('.cucumber-report'));formatter.uri('cucumberJava\AmazonValidation.feature');
formatter.feature({
  "line": 1,
  "name": "Amazon Validation",
  "description": "",
  "id": "amazon-validation",
  "keyword": "Feature"
});
formatter.scenario({
  "line": 3,
  "name": "Login and add to cart functionality works",
  "description": "",
  "id": "amazon-validation;login-and-add-to-cart-functionality-works",
  "type": "scenario",
  "keyword": "Scenario"
});
formatter.step({
  "line": 5,
  "name": "I go to Amazon.mx on browser",
  "keyword": "Given "
});
formatter.step({
  "line": 7,
  "name": "Successful login",
  "keyword": "When "
});
formatter.step({
  "line": 9,
  "name": "Validation of Phone and Monitor correct",
  "keyword": "Then "
});
formatter.match({
  "location": "annotation.createBrowser()"
});
formatter.result({
  "duration": 76520200,
  "status": "passed"
});
formatter.match({
  "location": "annotation.goToFacebook()"
});
formatter.result({
  "duration": 6003297400,
  "status": "passed"
});
formatter.match({
  "location": "annotation.loginButton()"
});
formatter.result({
  "duration": 16974414000,
  "status": "passed"
});
});