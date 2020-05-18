using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers{
  public class HomeController : Controller{
    [Route("/hello")]
    public string Hello(){return "Hi World" ;}
    [Route("/")]
    public ActionResult Index() { return View(); }
    [Route("/general")]
    public ActionResult Form() { return View(); }
    [Route("/madlibs")]
    public ActionResult MadLibs(string noun,string adjective,string adverb){
      WordVariable myWordVariable = new WordVariable();
      myWordVariable.Noun = noun;
      myWordVariable.Adjective = adjective;
      myWordVariable.Adverb = adverb;
      return View(myWordVariable);
    }
    [Route("/formHalloween")]
    public ActionResult HalloweenForm(){return View();}
    [Route("/madlibsHalloween")]
    public ActionResult Halloween(string verb1,string adjective1,
    string adjective2,string pluralNoun1,string pluralNoun2,string noun1,
    string adjective3,string color, string noun2, string adjective4,
    string animal,string verb2,string verb3){
    HalloweenVariable myHalloweenVariable = new HalloweenVariable();
    myHalloweenVariable.Verb1 = verb1;
    myHalloweenVariable.Adjective1 = adjective1;
    myHalloweenVariable.Adjective2 = adjective2;
    myHalloweenVariable.PluralNoun1 = pluralNoun1;
    myHalloweenVariable.PluralNoun2 = pluralNoun2;
    myHalloweenVariable.Noun1 = noun1;
    myHalloweenVariable.Adjective3 = adjective3;
    myHalloweenVariable.Color = color;
    myHalloweenVariable.Noun2 = noun2;
    myHalloweenVariable.Adjective4 = adjective4;
    myHalloweenVariable.Animal = animal;
    myHalloweenVariable.Verb2 = verb2;
    myHalloweenVariable.Verb3 = verb3;
    return View(myHalloweenVariable);
    }
  }
}
