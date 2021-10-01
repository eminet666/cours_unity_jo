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

## Component (accès à une instance, détruir
Attention il peut-être "null"e, ajouter)`
* Pour récupérer un composant existant sur un GameObject :
`GetComponent<MonComposant>()`, par exemple : 
```csharp
Rigidbody body = GetComposant<RigidBody>();
```
Attention il peut-être "null"

* Pour ajouter un composant sur un GameObject
`gameObject.AddComponent<MonComposant>()` par exemple :
```chsarp
gameObject.AddComponent<RigidBody>();
```

Remarque : Ctrl-cmd+Shif+V pour afficher le readme