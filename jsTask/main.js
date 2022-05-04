class Student {
    constructor(name, surname, point) {
        this.name = name;
        this.surname = surname;
        this.point = point
    }
}
let Student1 = new Student("Hikmet", "Abbasov", 35)
let Student2 = new Student("Allahverdi", "Akhmedov", 100)
let Student3 = new Student("Zibeyde", "Aliyeva", 100)
let Student4 = new Student("Abduleziz", "Karimli", 99)
let Student5 = new Student("Kamil", "Zeynalli", 0)

function filter(Student) {
    let arr = []
    for (let i = 0; i < Student.length; i++) {
        if (Student[i].point > 50) {
            arr[arr.length] = Student[i]
        }
    }
    return arr;
}
let newarr = filter([Student1, Student2, Student3, Student4, Student5])
console.log(newarr)

function repeat(word,count=1){
    let newword=""
    for(let i=0;i<count;i++){
        newword+=word;
    }
    return newword;
}
console.log(repeat("Necesuz muellim?",3))

function Even(number){
    let sum = 0;
    for(let i=0;i<number.length;i++){
        if(!isNaN(number[i])){
            if(number[i]%2==0)
            sum++;
        }
    }
    return sum;
}
