//Exercise 1
//to declare a block variable as salaries
let salaries = {
    John: 100, Ann:160, Peter: 130
}
//writing into an HTML element
document.getElementById("exercise1").innerHTML = 
salaries.John + salaries.Ann + salaries.Peter;



//Exercise 2
//before the call
let menu = { width: 200, height: 300, title: "My menu"};

//create a function multiplyNumeric(obj) : multiplyNumeric does not need to return anything. It should modify the object in-place
function multiplyNumeric(obj){
    for (let x in obj) {
        if (typeof obj[x] == "number") {  //"typeof" operator to find the data type of a JavaScript variable.
            obj[x] *= 2;   //obj[x] = obj[x] * y
        }
    }
}
//writing into an HTML element
document.getElementById("exercise2").innerHTML = multiplyNumeric(menu);
//writing into the browser console
console.log(menu);



//Exercise 3
//Write a function checkEmailId(str) that returns true if str contains '@' and ‘.’
//Make sure '@' must come before '.' and there must be some characters between '@' and '.'
function checkEmailId(str){

    for (let x in str){
        if (str.includes("@") == true && str.includes(".") == true) {
            if (str.indexOf(".") - str.indexOf("@") > 1){
                document.getElementById("emailoutput").innerHTML = "True";
                return true;
            }
        }
        document.getElementById("emailoutput").innerHTML = "False";
        return false;
    }
}
//writing into an HTML element
document.getElementById("exercise3-1").innerHTML = checkEmailId("123@abc.com");
document.getElementById("exercise3-2").innerHTML = checkEmailId("123.456@abc.com");
document.getElementById("exercise3-3").innerHTML = checkEmailId("123.456@abccom");



//Exercise 4
//Create a function truncate(str, maxlength) that checks the length of the str 
let text1 = "What I'd like to tell on this topic is:";
let text2 = "Hi everyone!";

function truncate(str, maxlength) {
    if (str.length > maxlength){
        return str.slice(0, maxlength-1) + "...";   //slice(start, end) will extract a part of a string and returns the extracted part in a new string.
    }
    return str;
}

document.getElementById("exercise4-1").innerHTML = truncate(text1, 20);
document.getElementById("exercise4-2").innerHTML = truncate(text2, 20);



//Exercise 5
const names = ["James", "Brennis"];

document.getElementById("exercise5-1").innerHTML = names; names.push("Robert");   //push() method will add a new element to an array at the "end"
document.getElementById("exercise5-2").innerHTML = names; names[Math.floor((names.length - 1) / 2 )] = "Calvin";   //Math.floor(x) method will returns x rounded down to its nearest integer
document.getElementById("exercise5-3").innerHTML = names; names.shift();   //shift() method will remove the FIRST array element and shifts all other elements to a lower index 
document.getElementById("exercise5-4").innerHTML = names; names.unshift("Rose", "Regal");   //unshift() method will add new elements to an array at the "beginning" and unshifts older elements
document.getElementById("exercise5-5").innerHTML = names;


