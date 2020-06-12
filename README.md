# dotty

https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-3.1&tabs=visual-studio-code

## Test PostTodoItem with Postman

Send POST with JSON body with Postman

```json
{
    "name": "walk dog",
    "isComplete": true
}
```

Verify it is created by visiting what is indicated in the redirect URL found
in the Response Location Header which should be something like:

https://localhost:5001/api/TodoItems/3