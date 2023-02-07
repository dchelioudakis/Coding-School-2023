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

