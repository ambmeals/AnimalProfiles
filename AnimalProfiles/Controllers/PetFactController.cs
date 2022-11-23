using Microsoft.AspNetCore.Mvc;

namespace AnimalProfiles.Controllers;

public class PetFactController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    private static readonly string[] EthelFacts =
    {
        "Drools", "Loves to sleep in the bathroom sink",
        "Enjoys sweets",
        "Hates cat treats",
        "Hunts trash",
        "Loves strangers",
        "1/2 a face of brown fur and 1/2 a face of orange fur"
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
        "Full name: Zuko Inyuasha Rengoku Mattli Mills",
        "Nickname: Firelord", "Amazing hunter",
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
        "His best friend does not have a jaw"
    };


    [HttpGet(Name = "GetPetFact")]
    public IEnumerable<PetLibrary> Get()
    {
        return Enumerable.Range(0, 1).Select(index => new PetLibrary
        {
            EthelFact = EthelFacts[Random.Shared.Next(EthelFacts.Length)],
            XanderFact = XanderFacts[Random.Shared.Next(XanderFacts.Length)],
            ZukoFact = ZukoFacts[Random.Shared.Next(ZukoFacts.Length)],
            ChuiFact = ChuiFacts[Random.Shared.Next(ChuiFacts.Length)],

        }).ToList();
    }
}