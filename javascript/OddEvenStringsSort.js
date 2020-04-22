function sortMyString(s) {
    let even = '', odd = '';

    for (let i = 0; i < s.length ; i++) {
        i % 2 === 0 ?  even += s[i] : odd += s[i];        
    }
    return even + ' ' + odd;
}

/* Better solutions 

const sortMyString = s => {
    let even = s.split('').filter((v, i) => i % 2 === 0).join('')
    let odd = s.split('').filter((v, i) => i % 2 !== 0).join('')
    return even + ' ' + odd
}