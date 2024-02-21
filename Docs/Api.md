# Buber Dinner API

- [Buber Dinner API](#buber-dinner-api)
    - [Auth](#auth)

## Auth

### Register

```js
POST {{host}}/auth/register
```

#### Register Request

```json
{
    "firstName": "Mikolaj",
    "lastName": "Kurleto",
    "email": "test@test.com",
    "password": "Pass123"
}
```

#### Register Response

```js
200 OK
```

```json
{
    "id": "d89c2d29a-eb3e-4075-95ff-b920b55aa104",
    "firstName": "Mikolaj",
    "lastName": "Kurleto",
    "email": "test@test.com",
    "token": "eyJhb...z9dqcnXoY"
}
```

### Login
```js
POST {{host}}/auth/login
```

#### Login Request
```json
{
    "email": "test@test.com",
    "password": "Pass123"
}
```

```js
200 OK
```

#### Login Response

```json
{
    "id": "d89c2d29a-eb3e-4075-95ff-b920b55aa104",
    "firstName": "Mikolaj",
    "lastName": "Kurleto",
    "email": "test@test.com",
    "token": "eyJhb...z9dqcnXoY"
}
```