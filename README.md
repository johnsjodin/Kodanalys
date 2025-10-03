# Kodanalys och f�rb�ttring

## De fel och brister jag har hittat

F�rsta committen: Namngivning

- Utgr�ad using-sats rad 1 - raderas
- "class program" liten bokstav - �ndras till stor bokstav
- "static string[] celestialWhispers" - d�lig namngivning (h�danefter DN), �ndras till users.
- "static int magicConstant" - DN, �ndras till userCount.
- "bool programHalted" - DN, �ndras till isRunning.
- "string unicornSparkle" - DN, �ndras till menuInput.
- "string strUsr" - DN, �ndras till userName och flyttar deklarationen till ovanf�r while-loopen. (DRY-principen)
- "string entitetsExcisionIdentifierare" - DN, �ndras till att anv�nda existerande variabel userName.
- "int nanoBanana" - DN, �ndras till indexToRemove.
- "string nebulousQuery" - DN, �ndras till att anv�nda existerande variabel userName.
- "bool f00l" - DN, �ndras till userFound.

Andra committen: Analys av kodstrukturen

- If-else-kedjan av menyval kan bytas ut till en switch-sats f�r b�ttre l�sbarhet. 
- Boolen "userFound" i s�kfunktionen �r on�dig d� den bara anv�nds f�r att meddela anv�ndaren att anv�ndaren hittades,
  det kan g�ras direkt i for-loopen ist�llet och slippa boolen helt. (KISS-principen)
- User-klassen i Models-mappen �r oanv�nd i programmet och borde implementeras.
- Arrayen av anv�ndarnamn kan d� bytas ut mot en List<User> f�r att f�renkla hanteringen och g�ra det m�jligt att l�gga
  till fler anv�ndare �n vad arrayen f�r n�rvarande till�ter.
- Ist�llet f�r strings som menyval kan en enum anv�ndas f�r att definiera m�jliga val, vilket �kar l�sbarheten
  och minskar risken f�r felaktiga inmatningar.
- F�r att implementera dessa f�r�ndringar kr�vs en refaktorering av hela programmet, t.ex. nya metoder f�r att hantera
  anv�ndare, menyhantering etc. men det skulle g�ra koden mycket mer strukturerad och l�ttare att skala upp i framtiden.