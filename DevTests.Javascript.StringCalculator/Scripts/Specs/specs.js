pavlov.specify("String Calculator", function() {

    describe("when calculating a string", function() {

        it("should be able to add 1+1", function() {
            var sum = StringCalculator.Calculate("1+1");
            assert(sum).equals(2);
        });

        it("should be able to add 2+2", function () {
            var sum = StringCalculator.Calculate("2+2");
            assert(sum).equals(4);
        });

        it("should be able to add multiple numbers", function () {
            var sum = StringCalculator.Calculate("2+2+5");
            assert(sum).equals(9);
        });

        it("should be able to subtract 3-1", function () {
            var sum = StringCalculator.Calculate("3-1");
            assert(sum).equals(2);
        });

        it("should be able to subtract 10-3", function () {
            var sum = StringCalculator.Calculate("10-3");
            assert(sum).equals(7);
        });

        it("should be able to subtract 10-3-20", function () {
            var sum = StringCalculator.Calculate("10-3-20");
            assert(sum).equals(-13);
        });
    });
});