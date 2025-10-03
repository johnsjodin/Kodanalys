# Kodanalys och förbättring

# De fel och brister jag har hittat

## Namngivning

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

## Analys av kodstrukturen

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

# Refaktorering och förbättringar

## Implementering av förbättringar

- Skapat en List<User> för att hantera användare istället för en array av strings.
- Refaktorerat koden i switch-casen för att hantera objekt av typen User.
- Bytt ut for-looparna i switchen mot foreach-loopar som passar bättre för Listor och arrayer.
- Bytt ut strängarna i menyvalen mot en enum för att öka läsbarheten och minska risken för felaktiga inmatningar.

## Slutgiltig analys och förbättringsförslag

- Lägg till mer robust validering av användarinmatning.
- Lägg till funktionalitet för att spara och ladda användardata från en fil eller databas.
- Refaktorera användargränssnittet för att göra det mer användarvänligt med tydligare meddelanden och snyggare meny.
- Lägg till fler properties i User-klassen för att lagra mer information om varje användare.
- Lägg till funktioner för att uppdatera användarinformation.
- Bryt ut kodblocken i menyvalen till egna metoder för att göra det mer läsbart och skalbart.

# Vad jag har lärt mig

Jag visste redan innan att namngivning är viktigt och jag blir lite irriterad varje gång jag ser slafsig kod med dåliga
namn, extra radbrytningar eller ingen radbrytning alls, indenteringar som ligger lite varstans... Det gör det så mycket
svårare att läsa och förstå koden, och det får mig att tänka att personen som har skrivit det inte tar sitt arbete på allvar.

Jag tänker ofta på att göra min kod så enkel och kort som möjligt. Nu gjorde jag inte det i det här programmet, men att
bryta ut funktionalitet till egna återanvändbara metoder försöker jag tänka på att göra så ofta som möjligt. Det är något
konstnärligt med att skriva kod som maximerar funktionalitet med minsta möjliga mängd tecken. Hoppas på att kunna växa
och lära mig i den konstformen under min karriär.

Men någonting nytt jag har lärt mig är att använda enums som menyval, det är ett riktigt bra sätt att öka läsbarheten och
få det se mer proffsigt ut. Det kommer jag fortsätta med.
