
# CrispLook Clothes API

- [CrispLook Clothes API](#CrispLook-Clothes-API)
  - [Create Clothe](#create-Clothe)
    - [Create Clothe Request](#create-Clothe-request)
    - [Create Clothe Response](#create-Clothe-response)
  - [Get Clothe](#get-Clothe)
    - [Get Clothe Request](#get-Clothe-request)
    - [Get Clothe Response](#get-Clothe-response)
  - [Update Clothe](#update-Clothe)
    - [Update Clothe Request](#update-Clothe-request)
    - [Update Clothe Response](#update-Clothe-response)
  - [Delete Clothe](#delete-Clothe)
    - [Delete Clothe Request](#delete-Clothe-request)
    - [Delete Clothe Response](#delete-Clothe-response)

## Create Clothe

### Create Clothe Request

```js
POST /Clothes
```

```json
{
    "name": "Delta Sunshine",
    "description": "Tailored Fit Casual wear for sunny days! ..",
    "startDateTime": "2022-04-08T08:00:00",
    "endDateTime": "2022-04-08T11:00:00",
    "Sizes": [
        "Small",
        "Medium",
        "Large",
        "ExtraLarge"
    ],
    "Trousers": [
        "White"
    ]
}
```

### Create Clothe Response

```js
201 Created
```

```yml
Location: {{host}}/Clothes/{{id}}
```

```json
{
    "id": "00000000-0000-0000-0000-000000000000",
    "name": "Delta Sunshine",
    "description": "Tailored Fit Casual wear for sunny days! ..",
    "startDateTime": "2022-04-08T08:00:00",
    "endDateTime": "2022-04-08T11:00:00",
    "lastModifiedDateTime": "2022-04-06T12:00:00",
    "Sizes": [
        "Small",
        "Medium",
        "Large",
        "ExtraLarge"
    ],
    "Trousers": [
        "White"
    ]
}
```

## Get Clothe

### Get Clothe Request

```js
GET /Clothes/{{id}}
```

### Get Clothe Response

```js
200 Ok
```

```json
{
   "id": "00000000-0000-0000-0000-000000000000",
    "name": "Delta Sunshine",
    "description": "Tailored Fit Casual wear for sunny days! ..",
    "startDateTime": "2022-04-08T08:00:00",
    "endDateTime": "2022-04-08T11:00:00",
    "lastModifiedDateTime": "2022-04-06T12:00:00",
    "Sizes": [
        "Small",
        "Medium",
        "Large",
        "ExtraLarge"
    ],
    "Trousers": [
        "White"
    ]
}
```

## Update Clothe

### Update Clothe Request

```js
PUT /Clothes/{{id}}
```

```json
{
    "name": "Delta Sunshine",
    "description": "Tailored Fit Casual wear for sunny days! ..",
    "startDateTime": "2022-04-08T08:00:00",
    "endDateTime": "2022-04-08T11:00:00",
    "Sizes": [
        "Small",
        "Medium",
        "Large",
        "ExtraLarge"
    ],
    "Trousers": [
        "White"
    ]
}
```

### Update Clothe Response

```js
204 No Content
```

or

```js
201 Created
```

```yml
Location: {{host}}/Clothes/{{id}}
```

## Delete Clothe

### Delete Clothe Request

```js
DELETE /Clothes/{{id}}
```

### Delete Clothe Response

```js
204 No Content
```