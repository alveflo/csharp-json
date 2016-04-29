# csharp-json
[Experimental]

Tiny expando based library which behaves like json

### Usage
##### Creating a json object
```csharp
dynamic obj = Json.New();
obj.foo = "Foo";
obj.bar = Json.New();
obj.bar.baz = "Baz!";
```
##### Stringify
From example above:
```csharp
obj.Stringify();
```
Produces
```javascript
{
  "foo": "Foo",
  "bar": {
    "baz": "Baz!"
  }
}
```
### License
MIT
