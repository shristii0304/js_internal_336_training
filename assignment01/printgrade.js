function printGrade(marks) {
    let grade;

    if (marks >= 90) {
        grade = "A";
    } else if (marks >= 75) {
        grade = "B";
    } else if (marks >= 50) {
        grade = "C";
    } else {
        grade = "Fail";
    }

    return grade;
}

let marks = 82;
console.log("Marks:", marks, "Grade:", printGrade(marks));
