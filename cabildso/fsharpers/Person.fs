module Person
    type T = {First:string; Last:string} with
       // member defined with type declaration
        member this.FullName = 
            this.First + " " + this.Last

    // constructor
    let create first last = 
        {First=first; Last=last}

    // another member added later
    type T with 
        member this.SortableName = 
            this.Last + ", " + this.First        