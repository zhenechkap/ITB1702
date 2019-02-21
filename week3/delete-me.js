function beforeTryCatch() {

    let obj = undefined;
    console.log(obj.b);
    console.log('If the previous line of code throws an exception, you\'ll never see this.');
}


function afterTryCatch() {

    try {
        let obj = undefined;
        console.log(obj.b);
        console.log('If the previous line of code throws an exception, you\'ll never see this.');        

    } catch (error) {
        // console.log(error);
        console.log(`I caught an error: ${error.message}`)
    } finally {
        console.log('Whether the try block succeeds or catches, this will always be performed.');
    }

    console.log('... but I can continue executing!');
}

// beforeTryCatch();
//afterTryCatch();

function performCalculation(obj) {
    if (!Object.hasOwnProperty('b'))
        throw new Error('Object missing property b');
    return true;
}

function performHigherLevelOperation() {
    let obj;
    let success = false;
    try {
        success = performCalculation(obj);
    } catch (error) {
        console.log(error.message);
    }

    if (!success) {
        // Contingency
    }
}

performHigherLevelOperation();