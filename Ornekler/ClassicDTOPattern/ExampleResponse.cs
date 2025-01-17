namespace YazilimNetFrameworkOrnekler.Ornekler.ClassicDTOPattern
{
    internal class ExampleResponse
    {
        BaseResponse response = new BaseResponse
        {
            status = true,
            statusCode = 200,
            data = new ExampleData
            {
                desc = "Example Description",
                name = "John",
                surname = "Doe",
                age = 30
            }
        };

        BaseResponse<ExampleData> response2 = new BaseResponse<ExampleData>
        {
            status = true,
            statusCode = 200,
            data = new ExampleData
            {
                desc = "Example Description",
                name = "John",
                surname = "Doe",
                age = 30
            }
        };

        private void DoSomething()
        {
            response.data.desc = "New Description";
            //response.data.age = 25; // 2. Olanda data içindeki verilere erişilebilirken 1.olanda erişim yoktur.
            response2.data.desc = "New Description";
            response2.data.age = 25;
        }
    }

    internal class ExampleData : BaseResponseData
    {
        public string name { get; set; }
        public string surname { get; set; }
        public int age { get; set; }
    }
}
