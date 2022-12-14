using Microsoft.AspNetCore.Mvc;

namespace AnimalProfiles.Controllers;

public class AnimalFactController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    private static readonly string[] EthelFacts =
    {
        "Drools", 
        "Loves to sleep in the bathroom sink",
        "Enjoys sweets",
        "Hates cat treats",
        "Hunts trash",
        "Loves strangers",
        "2 faced!\n1/2 brown & 1/2 orange"
    };

    private static readonly string[] XanderFacts =
    {
        "Nebelung",
        "Missing 1 front tooth",
        "Loves to sunbathe",
        "Enjoys a good basement",
        "Bit of a scardy cat",
        "Worships the space heater",
        "Will bite for attention"
    };

    private static readonly string[] ZukoFacts =
    {
        "Full name:\nZuko Inyuasha Rengoku Mattli Mills",
        "Nickname:\nFirelord", "Amazing hunter",
        "Cheeks like pikachu",
        "Adopted from Craigslist",
        "Enjoys tormenting his siblings",
        "Has a gap in his front teeth",
        "Enjoys neck scratches"
    };

    private static readonly string[] ChuiFacts =
    {
        "Pomchi ALLEGEDLY",
        "Natural blonde",
        "Loves winter",
        "Will eat garbage",
        "Sneaky little devil",
        "Knows the tea",
        "Thinks he is a cat",
        "Is happiest when being a menace to society",
        "His best friend does not have a jaw",
        "Has great eyebrows"
    };

    [HttpGet]
    public ActionResult GetPetFact()
    {
        return Json(Enumerable.Range(0, 1).Select(index => new PetLibrary
        {
            EthelFact = EthelFacts[Random.Shared.Next(EthelFacts.Length)],
            XanderFact = XanderFacts[Random.Shared.Next(XanderFacts.Length)],
            ZukoFact = ZukoFacts[Random.Shared.Next(ZukoFacts.Length)],
            ChuiFact = ChuiFacts[Random.Shared.Next(ChuiFacts.Length)],

        }).ToList());
    }
}