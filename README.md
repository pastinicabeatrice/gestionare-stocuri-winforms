# Gestionare stocuri

Aplicație Windows Forms pentru gestiunea materialelor și a operațiilor de stoc, cu bază de date SQL Server prin Entity Framework.

## Funcționalități

- materiale (nume, cod de bare, cantitate, preț, dată de expirare, furnizor, categorie): adăugare, actualizare, ștergere
- operații de stoc pe materiale: adăugare, actualizare, ștergere
- validarea câmpurilor cu `ErrorProvider`
- salvarea și încărcarea datelor din fișier, serializare binară
- export de raport în `raport_materiale.txt`
- printare și previzualizare a printării
- grafic desenat pentru materiale
- copiere / lipire prin clipboard și drag & drop
- control personalizat `MaterialControl`
- scurtături de tastatură (Alt + A adaugă, Alt + U actualizează, Alt + Ș șterge etc.), descrise în `docs/README-documentatie.txt`
- erorile sunt scrise în `error_log.txt`

## Tehnologii

C#, .NET Framework, Windows Forms, Entity Framework 6 (Code First, migrări), SQL Server

## Rulare

1. Este nevoie de un SQL Server local. Șirul de conexiune este în `GestionareStocuri/App.config`
   (implicit `Data Source=localhost;Initial Catalog=GestionareStocuriDB;Integrated Security=True`).
2. Se deschide `Gestionare Stocuri.sln` în Visual Studio și se restaurează pachetele NuGet.
3. Baza de date este creată și populată automat la prima rulare (`DbInitializer`). Alternativ, din Package Manager Console: `Update-Database`.
