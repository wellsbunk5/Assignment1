// when you click on the submit button do this function
$("#submit").click(function () {
    // declare and assign values from the form
    var assignments = $("#assignments").val();
    var quizzes = $("#quizzes").val();
    var groupproj = $("#groupproj").val();
    var exams = $("#exams").val();
    var intex = $("#intex").val();

    var finalpercent;
    var lettergrade;

    // calculate the final percent
    finalpercent = (assignments * .5) + (quizzes * .1) + (groupproj * .1) + (exams * .2) + (intex * .1);

    //calculate the letter grade using an if statement
    if (finalpercent >= 94) {
        lettergrade = "A"
    }
    else if (finalpercent >= 90 && finalpercent < 94) {
        lettergrade = "A-"
    }
    else if (finalpercent >= 87 && finalpercent < 90) {
        lettergrade = "B+"
    }
    else if (finalpercent >= 84 && finalpercent < 87) {
        lettergrade = "B"
    }
    else if (finalpercent >= 80 && finalpercent < 84) {
        lettergrade = "B-"
    }
    else if (finalpercent >= 77 && finalpercent < 80) {
        lettergrade = "C+"
    }
    else if (finalpercent >= 74 && finalpercent < 77) {
        lettergrade = "C"
    }
    else if (finalpercent >= 70 && finalpercent < 74) {
        lettergrade = "C-"
    }
    else if (finalpercent >= 67 && finalpercent < 70) {
        lettergrade = "D+"
    }
    else if (finalpercent >= 64 && finalpercent < 67) {
        lettergrade = "D"
    }
    else if (finalpercent >= 60 && finalpercent < 64) {
        lettergrade = "D-"
    }
    else {
        lettergrade = "E"
    }

    // alert the letter grade and the final percent
    alert("Letter Grade: " + lettergrade + ", Percent: " + finalpercent);
});