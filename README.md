# Prime Factors Azure Function

## Beschreibung

Diese Azure Function berechnet die Primfaktoren einer Zahl.

Die Zahl wird über den Query-Parameter `zahl` übergeben.

Beispiel:

https://dm-primefactors-function.azurewebsites.net/api/Function1?zahl=100

Ergebnis:

Primfaktoren: 2 2 5 5

## Verwendete Azure-Ressourcen

- Resource Group: PrimeFactorsRG
- Storage Account: dmprimefactors2026
- Function App: dm-primefactors-function

## Hinweis

Die Anwendung wurde mit Azure Functions und C# erstellt und anschließend in Azure veröffentlicht.
