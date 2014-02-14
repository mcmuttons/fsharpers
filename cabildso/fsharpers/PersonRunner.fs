module PersonRunner

open PersonExtensions

let person = Person.create "John" "Doe"
let uppercaseName = person.UppercaseName 
