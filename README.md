# Kodanalys och f�rb�ttring

## De fel och brister jag har hittat

# Namngivning

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

# Analys av kodstrukturen

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

## Refaktorering och f�rb�ttringar

# Implementering av f�rb�ttringar

- Skapat en List<User> f�r att hantera anv�ndare ist�llet f�r en array av strings.
- Refaktorerat koden i switch-casen f�r att hantera objekt av typen User.
- Bytt ut for-looparna i switchen mot foreach-loopar som passar b�ttre f�r Listor och arrayer.
- Bytt ut str�ngarna i menyvalen mot en enum f�r att �ka l�sbarheten och minska risken f�r felaktiga inmatningar.

# Slutgiltig analys och f�rb�ttringsf�rslag

- L�gg till mer robust validering av anv�ndarinmatning.
- L�gg till funktionalitet f�r att spara och ladda anv�ndardata fr�n en fil eller databas.
- Refaktorera anv�ndargr�nssnittet f�r att g�ra det mer anv�ndarv�nligt med tydligare meddelanden och snyggare meny.
- L�gg till fler properties i User-klassen f�r att lagra mer information om varje anv�ndare.
- L�gg till funktioner f�r att uppdatera anv�ndarinformation.
- Bryt ut kodblocken i menyvalen till egna metoder f�r att g�ra det mer l�sbart och skalbart.

## Vad jag har l�rt mig

Jag visste redan innan att namngivning �r viktigt och jag blir lite irriterad varje g�ng jag ser slafsig kod med d�liga
namn, extra radbrytningar eller ingen radbrytning alls, indenteringar som ligger lite varstans... Det g�r det s� mycket
sv�rare att l�sa och f�rst� koden, och det f�r mig att t�nka att personen som har skrivit det inte tar sitt arbete p� allvar.

Jag t�nker ofta p� att g�ra min kod s� enkel och kort som m�jligt. Nu gjorde jag inte det i det h�r programmet, men att
bryta ut funktionalitet till egna �teranv�ndbara metoder f�rs�ker jag t�nka p� att g�ra s� ofta som m�jligt. Det �r n�got
konstn�rligt med att skriva kod som maximerar funktionalitet med minsta m�jliga m�ngd tecken. Hoppas p� att kunna v�xa
och l�ra mig i den konstformen under min karri�r.

Men n�gonting nytt jag har l�rt mig �r att anv�nda enums som menyval, det �r ett riktigt bra s�tt att �ka l�sbarheten och
f� det se mer proffsigt ut. Det kommer jag forts�tta med.