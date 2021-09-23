# cours_unity_jo

## vie et mort
Pour détruire un comosant ou un gameObject
```csharp
Destroy(gameObject);
// avec un delai de 3s
Destroy(gameObject, 3f);
```
Pour créer un gameObject à partir d'une source :
- existant dans la scène
```csharp
Instantiate(gameObject);
```

- et en la détruisant ensuite
```csharp
GameObject clone = Instantiate(gameObject);
Destroy(clone, 5f);
```
[voir usage dans CloneOnClick](./assets/CloneOnClic.cs)