module PersonExtensions  
    type Person.T with 
    member this.UppercaseName = 
        this.FullName.ToUpper()
