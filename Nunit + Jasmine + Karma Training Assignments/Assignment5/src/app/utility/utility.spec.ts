import { Utility } from './utility';

describe('Utility', () => {

  let spy: any;
  let utility: Utility;

  beforeEach(() => {
    utility = new Utility;
  });

  // Positive Test Case
  it('Sum of 2 numbers in +ve case', () => {
    expect(utility.sumOperation(10,20)).toEqual(30);
  });

  // Positive Test Case with spy
  it('Sum of 2 numbers in +ve case', () => {
    spy = spyOn(utility, 'sumOperation').and.returnValue(30);
    expect(utility.sumOperation(10,20)).toEqual(30);
    expect(utility.sumOperation).toHaveBeenCalled(); // checks whether fuction 'sumOperation()' has been called or not;
  });

  // Negative Test Case with spy
  it('Sum of 2 numbers in -ve case', () => {
    spy = spyOn(utility, 'sumOperation').and.rejectWith();
    expect(utility.sumOperation(10,20)).not.toEqual(10);
  });

  // Positive Test Case with spy
  it('Average of 3 numbers in +ve case', () => {
    spy = spyOn(utility, 'averageOperation').and.returnValue(20);
    expect(utility.averageOperation(10,20,30)).toEqual(20);
    expect(utility.averageOperation).toHaveBeenCalled(); // checks whether fuction 'averageOperation()' has been called or not;
  });

  // Negative Test Case with spy
  it('Average of 3 numbers in -ve case', () => {
    spy = spyOn(utility, 'averageOperation').and.rejectWith();
    expect(utility.averageOperation(10,20,30)).not.toEqual(10);
  });

});
