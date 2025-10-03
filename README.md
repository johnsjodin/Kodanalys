# Kodanalys och förbättring

## De fel och brister jag har hittat

Första committen: Namngivning

- Utgråad using-sats rad 1 - raderas
- "class program" liten bokstav - ändras till stor bokstav
- "static string[] celestialWhispers" - dålig namngivning (hädanefter DN), ändras till users.
- "static int magicConstant" - DN, ändras till userCount.
- "bool programHalted" - DN, ändras till isRunning.
- "string unicornSparkle" - DN, ändras till menuInput.
- "string strUsr" - DN, ändras till userName och flyttar deklarationen till ovanför while-loopen. (DRY-principen)
- "string entitetsExcisionIdentifierare" - DN, ändras till att använda existerande variabel userName.
- "int nanoBanana" - DN, ändras till indexToRemove.
- "string nebulousQuery" - DN, ändras till att använda existerande variabel userName.
- "bool f00l" - DN, ändras till userFound.

Andra committen: Analys av kodstrukturen

- If-else-kedjan av menyval kan bytas ut till en switch-sats för bättre läsbarhet. 
- Boolen "userFound" i sökfunktionen är onödig då den bara används för att meddela användaren att användaren hittades,
  det kan göras direkt i for-loopen istället och slippa boolen helt. (KISS-principen)
- User-klassen i Models-mappen är oanvänd i programmet och borde implementeras.
- Arrayen av användarnamn kan då bytas ut mot en List<User> för att förenkla hanteringen och göra det möjligt att lägga
  till fler användare än vad arrayen för närvarande tillåter.
- Istället för strings som menyval kan en enum användas för att definiera möjliga val, vilket ökar läsbarheten
  och minskar risken för felaktiga inmatningar.
- För att implementera dessa förändringar krävs en refaktorering av hela programmet, t.ex. nya metoder för att hantera
  användare, menyhantering etc. men det skulle göra koden mycket mer strukturerad och lättare att skala upp i framtiden.