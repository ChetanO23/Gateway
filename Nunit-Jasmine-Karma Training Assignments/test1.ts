const addFunction = (a: Number, b: Number) => {
    //if(a>0 && b>0) // Add new features without breaking anything
    return a + b;
}

const positiveAddFunction=(a: Number, b: Number) => {
    if(a>0 && b>0)
    return addFunction(a,b);
}

const result = addFunction(-9, -5)

<h1>{{result}}</h1>

//test file
test1(" Should return add result by args"() =>
{
    //Arrange
    const a = 2;
    const b = 5;

    //Act
    const result = addFunction(a,b);
    
    //Assert 
    expect(result.toBe(7))
});

test1(" Should return add result by negative args"() =>
{
    //Arrange
    const a = -5;
    const b = -6;

    //Act
    const result = addFunction(a,b);
    
    //Assert 
    expect(result.toBe(-11))
});

test1(" Should return positiveAddFunction result by negetive args"() =>
{
    //Arrange
    const a = -5;
    const b = -6;

    //Act
    const result = positiveAddFunction(a,b);
    
    //Assert 
    expect(result.toBe(0))
});

//Improve the design of Implementations
const positiveAddFunction=(a: Number, b: Number) => {
    try{
        if(a>0 && b>0)
        return addFunction(a,b);
    }
    catch (err) {
        throw new Error("addFunction is not working")
    }
}

// Allows refactoring
const calc = (a:Number, b:Number, c:String)
{
    switch(c){
        case 'Add':
            return addFunction(a, b);
            break;
        case 'Subs':
            return Subs(a, b);
            break; 
        case 'Mult':
            return Mult(a, b);
            break;
                                
    }
}

function Subs(a:Number, b:Number)
{
    return a - b;
}

function Mult(a:Number, b:Number)
{
    return a * b;
}

