/*
    Learnt : Spread operator on string converts it into an array with an iterator

*/
function AlphabetPosition(text) {

    const upperCase = text.toUpperCase();
    let result = '';

    [...upperCase].forEach( (chr,idx) => {
        let charCode = upperCase.charCodeAt(idx);
        if ( charCode >= 65 && charCode <= 90) {
            result += (charCode - 64) + ' ';
        }
    });

    return result.trim();
}

/* Best Solution :

function alphabetPosition(text) {
  return text
    .toUpperCase()
    .match(/[a-z]/gi)
    .map( (c) => c.charCodeAt() - 64)
    .join(' ');
}

*/