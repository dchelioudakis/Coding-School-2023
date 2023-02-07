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

}



function reverseBtn(){
    var inputValue = document.querySelector("#reverse-input").value;
    const manipulator = new StringManipulator(inputValue);

    manipulator.reverseString();
    manipulator.displayReversed();

}