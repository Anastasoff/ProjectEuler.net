function isPrime(number) {
    var isNumberPrime = true,
        maxDevider = Math.sqrt(number);

    for (var i = 2; i <= maxDevider; i++) {
        if (number % i === 0) {
            isNumberPrime = false;
            break;
        }
    }

    return isNumberPrime;
}

function findNhPrime(start, end) {
    var primesList = [];

    // TODO: while loop, counter, if counter == searched prime -> return counter
    for (var i = start; i < end; i++) {
        var isNumberPrime = isPrime(i);
        if (isNumberPrime) {
            primesList.push(i);
        }
    }

    return primesList;
}

var result = findNhPrime(1, 104745);

for (var i = result.length - 1; i < result.length; i++) {
    console.log(i + ' > ' + result[i]);
}