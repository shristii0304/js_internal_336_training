function checkVotingEligibility(age) {
    if (age >= 18) {
        return "You are eligible to vote.";
    } else {
        return "You are NOT eligible to vote.";
    }
}
console.log(checkVotingEligibility(20));  
