class StringManipulator{
    constructor(inputString) {
        this.InputString = inputString;
        this.ReversedString = "";
    }

    reverseString(){
        this.ReversedString = "";
        for(var i = this.InputString.length-1; i >= 0; i--){
            this.ReversedString += this.InputString.charAt(i);
        }
    }

    displayReversed(){
        document.querySelector("#reversed-field").value = this.ReversedString;
    }

    palindomeCheck(){
        if(this.InputString == this.ReversedString){
            document.querySelector("#palindromeCheckResult-field").value = "It `s palindrome!";
        }
        else{
            document.querySelector("#palindromeCheckResult-field").value = "Not palindrome!";
        }
    }
    // Exercise 5
    stringNumCheck(){
        var lastChar = this.InputString.charAt(this.InputString.length-1);
        
        if(isNaN(parseInt(lastChar))){
            document.querySelector("#stringNumCheck-field").value = this.InputString + "1";
        }
        else{
            var numberStartIndex = this.InputString.length-1;

            for(var i = this.InputString.length-2; i >= 0; i--){
                var currentChar = this.InputString.charAt(i);
                if(isNaN(parseInt(currentChar))){
                    numberStartIndex = i+1;
                    break;
                }
            }
            var number = parseInt(this.InputString.slice(numberStartIndex,));
            document.querySelector("#stringNumCheck-field").value = this.InputString.slice(0,numberStartIndex) + (number+1);
        }
    }

}



function reverseBtn(){
    var inputValue = document.querySelector("#reverse-input").value;
    const manipulator = new StringManipulator(inputValue);

    manipulator.reverseString();
    manipulator.displayReversed();

}

function palindromeBtn(){
    var inputValue = document.querySelector("#palindrome-check").value;
    const manipulator = new StringManipulator(inputValue.toUpperCase());

    manipulator.reverseString();
    manipulator.palindomeCheck();
}

function checkNumBtn(){
    var inputValue = document.querySelector("#stringNum-check").value;
    const manipulator = new StringManipulator(inputValue);

    manipulator.stringNumCheck();

}