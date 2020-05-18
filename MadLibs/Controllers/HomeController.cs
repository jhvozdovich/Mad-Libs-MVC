using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers{
  public class HomeController : Controller{
    [Route("/hello")]
    public string Hello(){return "Hi World" ;}
    [Route("/")]
    public ActionResult Form() { return View(); }
    [Route("/madlibs")]
    public ActionResult MadLibs(string noun,string adjective,string adverb){
      WordVariable myWordVariable = new WordVariable();
      myWordVariable.Noun = noun;
      myWordVariable.Adjective = adjective;
      myWordVariable.Adverb = adverb;
      return View(myWordVariable);
    }
  }
}