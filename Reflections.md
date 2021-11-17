**FUNKTIONER OCH STRUKTUR**

Min kods funktioner och struktur baseras på vad beställaren vill ha som krav på programmet. Med det sagt så har fabriken produkter att sälja och produkterna är bilar, snören, godis och tofu, utöver detta kan varje produkt köpas, och att kunna visa upp de köpta produkterna.

Så jag gjorde en huvudklass som heter Product, gav den alla fält[fields] som vi behöver för underklasserna och gav den också 2 metoder, en för att köpa produkten och den andra är för att visa de köpta produkterna. Efter det skapade jag en underklass för varje produkt[carClass,candyClass,stringsClass,tofuClass]och gav varje underklass en konstruktor för att instansiera klassfälten som användarinmatning, och inuti varje klass skapar jag också de 2 metoderna **orderComplete()** och **ordered()** i Product klassen.

För Main metoden började jag med att skriva ut introduktion till programmet och sedan en meny med produkter att välja mellan när kunden vill göra en beställning. Efter det kollar jag vilket val menyn användaren valde och utifrån det skapar programmet ett nytt objekt och lägger till det i en produktlista, samt anropa metoden **orderComplete()[Den-visar-köpta-produkter-efter-köpet]** på det skapade objektet. i fall användaren väljer att visa köpta produkter så kallar jag på metoden **ordered()**.

[Anledningen-till-att-jag-valde-denna-STRUKTUR] är för att göra det tydligt för andra programmerare att hoppa in i projektet, genom att det finns en huvudclass Product och då kan andra lägga till klasser och eller metoder av andra produkter eller till och med modifiera koden i klasserna.

**ANALYS**

Jag har aldrig programmerat med OOP men jag tycker att den här strukturen verkar vara den mest grundläggande och logiska strukturen i ett liknande program, men det måste naturligtvis finnas tusen andra sätt att göra det bättre på, och naturligtvis kan det göras mycket mer för att göra det här programmet bättre, en av sakerna är felshantering och att fält krävs, vilket kan göras genom att kontrollera om den strängen är tom och sedan inte tillåta användaren att gå framåt. En annan sak skulle också vara att begränsa de inmatade tecknen i användarinmatning.
När det kommer till block koden inuti switch selektion känns det som att nästan samma kod upprepas i varje fall, vilket jag tror man kan göra en metod för så att vi inte behöver upprepa samma kod varje gång.
Jag försökte fånga några fel men jag har inte en djup kunskap när det gäller felhantering, men det här programmet kan göras bättre om programmet inte går tillbaka till huvudmenyn när det upptäcker felet, utan istället bör stanna kvar i inmatningsfältet där felet uppstod.
Ett problem jag stötte på var när användaren väljer att se de beställda produkterna, men jag kunde inte loopa igenom den tomma produktlistan för att tala om för användaren att hen inte har några beställningar, men jag fixade det genom att kontrollera [list.count()], om den är tom så finns det inga beställningar, och om antalet är större än 0, visa beställningarna.
En annan sak som skulle kunna vara en förbättring är att skapa en klass för beställningarna och sedan skapa ett nytt objekt för varje beställning.

[Till-slut] och som ett resultat fungerar programmet som förväntat och kraven är uppfyllda. 
