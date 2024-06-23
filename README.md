# King ICT akademija

U projektu je napravljen middleware REST API koji dohvaća proizvode iz drugog REST API-ja. Ovaj projekt obuhvaća 4 endpointa, a to su dohvaćanje svih proizvoda, dohvaćanje proizvoda po id-u, traženje proizvoda po nazivu i filtriranje proizvoda po kategoriji i cijeni (daljnji opisi svakog endpointa se nalazi niže u dokumentu). U projektu je korištena troslojna arhitektura koja se sastoji od sloja kontrolera, sloja poslovne logike i podatkovnog sloja.

## Korištene tehnologije:
- .Net verzija 8
- ASP .NET Web API

## Pokretanje projekta

Za pokretanje projekta se može izvršiti pritiskom na gumb f5 unutar Visual Studio-a. Nakon što se pokrene projekt se otvara Swagger unutar kojeg se mogu testirati endpointi.

## Endpoint za dohvaćanje svih proizvoda
GET api/product/

Vraća listu proizvoda sa sljedećim informacijama: 
  id, name, price, shortDescription, category, image.
### Primjer zahtjeva:
GET /api/product

Primjer odgovora:
Status kod: 200 OK

Tijelo odgovora:
```
[
  {
    "id": 1,
    "name": "Product 1",
    "price": 29.99,
    "shortDescription": "This is a short description of Product 1",
    "category": "Category 1",
    "image": "https://example.com/image1.jpg"
  },
  {
    "id": 2,
    "name": "Product 2",
    "price": 49.99,
    "shortDescription": "This is a short description of Product 2",
    "category": "Category 2",
    "image": "https://example.com/image2.jpg"
  }
]
```

## Endpoint za dohvaćanje jednog proizvoda preko id-a
GET api/product/{id}

Vraća proizvod sa istim id-am i sljedećim informacijama:

id, name, price, shortDescription, category, image.

### Ovaj endpoint prima 1 parametar:
- id (int): ID proizvoda.

### Primjer zahtjeva:
GET /api/product/1

Primjer odgovora:

Status kod: 200 OK

Tijelo odgovora:
```
{
  "id": 1,
  "name": "Product 1",
  "price": 29.99,
  "shortDescription": "This is a short description of Product 1",
  "category": "Category 1",
  "image": "https://example.com/image1.jpg"
}
```

## Endpoint za pretraživanje proizvoda po nazivu
GET api/product/search

Vraća listu proizvoda koji u sebi sadrže skup znakova zapisanog u polje i vraća ih sa sljedećim informacijama:

id, name, price, shortDescription, category, image.

### Ovaj endpoint prima 1 parametar:
- searchText (string): Tekst za pretragu u nazivu proizvoda.

### Primjer zahtjeva:
GET /api/product/search?searchText=example

Primjer odgovora:

Status kod: 200 OK

Tijelo odgovora:
```
[
  {
    "id": 1,
    "name": "Example Product 1",
    "price": 29.99,
    "shortDescription": "This is a short description of Example Product 1",
    "category": "Category 1",
    "image": "https://example.com/image1.jpg"
  }
]
```

## Endpoint za filtriranje proizvoda po kategoriji i cijeni
GET api/product/filter

Vraća listu proizvoda koji ispunjavaju uvjete filtriranja po kategoriji i cijeni. Vraćeni podatci sadrže sljedeće informacije:

id, name, price, shortDescription, category, image.

### Ovaj endpoint prima 3 parametra:
- category (string, optional): Kategorija proizvoda.
- minPrice (decimal, optional): Minimalna cijena proizvoda.
- maxPrice (decimal, optional): Maksimalna cijena proizvoda.

### Primjer zahtjeva:
GET /api/product/filter?category=Category 1&minPrice=10&maxPrice=50

Primjer odgovora:

Status kod: 200 OK

Tijelo odgovora:
```
[
  {
    "id": 1,
    "name": "Product 1",
    "price": 29.99,
    "shortDescription": "This is a short description of Product 1",
    "category": "Category 1",
    "image": "https://example.com/image1.jpg"
  }
]
```
