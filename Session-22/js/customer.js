var customersList = [
    {
        "ID" : "654689798", 
        "Name" : "Jim",
        "Surname" : "Bean",
        "Age" :  "35",
        "Gender" : "Male"
    },
    {
        "ID" : "65468987298", 
        "Name" : "Dimitris",
        "Surname" : "Chelioudakis",
        "Age" :  "28",
        "Gender" : "Male"
    }
];



class Customer{
    constructor(name, surname, age, gender) {
        this.ID = Date.now();
        this.Name = name;
        this.Surname = surname;
        this.Age = age;
        this.Gender = gender;
    }

    addToCustomersList(){
        customersList.push(this);
    }

    

}

function createCustomersTable(){
    var tableBody = document.querySelector("#customersTable").querySelector("tbody");

    customersList.forEach(customer => {
        var newRow = document.createElement("tr");
        newRow.onclick = "window.alert('asda')";
        
        
        for (const [key, value] of Object.entries(customer)) {
            if(key == "ID"){continue;}
            var newCell = document.createElement("td");
            newCell.innerText = value;
            newRow.appendChild(newCell);
        }
        
        
        tableBody.appendChild(newRow);
        
    });
}



function displayCustomerByID(ID){
    customerToDisplay = customersList.find(customer => customer.ID === ID);
    window.alert(customerToDisplay.Name);
}