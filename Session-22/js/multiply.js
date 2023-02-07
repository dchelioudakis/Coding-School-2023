function multiply(a,b){
    if(isNaN(parseInt(a)) || isNaN(parseInt(b))){
        window.alert("Invalid Input");
        return;
    }
    return a*b;
}