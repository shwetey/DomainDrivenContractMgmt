## Problem Statement - 

Your task is to develop an API endpoint for a Contract Management system using Domain-Driven Design (DDD) principles. The focus should be on implementing the Service Layer and Repository layer to manage entities such as "Contracts" and "Products."

## Implementation Criteria -
- Define two core entities: "Contracts" and "Products."
- Consider Domain Modelling
- Use Sets instead Lists
- No Use Of foreach loop
- Datasource - could be a flat structure (eg. json file) or any open source library

## Evaluation Criteria - 
- Adherence to DDD principles and best practices.
- Proper implementation of the Service Layer and Repository layer.
- Effective use of sets and alternative constructs for traversing records.
- Clear and concise API design.
- Proper documentation of the code and design choices.

## Expected output - 
```yml
"Contracts": {
  "_id": "GUID",
  "Name": "Contract Name",
  "CountryId": 4,
  "Products": [
    {
      "_id": "GUID",
      "Elements": [
        {
          "_t": "VolumeRisk",
          "Fee": "-33.53 EUR/MWh"
        },
        {
          "_t": "CrossSubsidization",
          "Price": null
        }
      ]
    }
  ]
}
```
## Solution Approach - 

Domain Driven Design (DDD) has been used to implement the given challenge. As part of the solution, 3 projects have been defined -

* ContractManagement - This contains the Application Layer
* Domain - This contains the Domain Model Layer
* Infrastructure - This contains the Infrastructure Layer

1. ContractManagement contains the API Controller which is responsible for handling inputs. GET and POST methods have been implemented to store and retrieve Contracts.
2. Domain contains the Entity models for Contract, Product and Element.
3. Infrastructure contains the logic for interacting with the Repository, which in this case is json file.

## How To Run -
Pull the code present in main and use Visual Studio 2022 to run. Set Startup Project as ContractManagement.

1. For GET Method use -
``` url
http://localhost:5000/api/contracts/<contract_id>
```
2. For POST Method use - (To add product)
``` url
http://localhost:5000/api/contracts/<contract_id>/products
```
3. For POST Method use - (To add element)
``` url
http://localhost:5000/api/contracts/<contract_id>/products/<product_id>/elements
```

## Sample Requests -
1. Get request -
```url
   http://localhost:5000/api/contracts/contract1
```
## Response -
Success - 200 OK with associated Contract.
In case Contract does not exist - 404 Not Found

2. Post request - (To add product)
```url
   http://localhost:5000/api/contracts/contract1/products
```
```yml
{
        "_id": "product2",
        "Elements": [
          {
            "_t": "VolumeRisk",
            "Fee": "-33.53 Eur/Mwh",
            "Price": 10
          },
          {
            "_t": "CrossSubsidization",
            "Fee": null,
            "Price": 20
          }
        ]
}
```
## Response -
Success - 200 OK with the message - Product added successfully.

3. Post request - (To add element)
```url
   http://localhost:5000/api/contracts/contract1/products/product1/elements
```
```yml
  {
    "_t": "VolumeRisk",
    "Fee": "-33.53 Eur/Mwh",
    "Price": 100
  }
```
## Response -
Success - 200 OK with the message - Element added successfully.
