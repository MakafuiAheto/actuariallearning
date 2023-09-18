using System.Reflection;


namespace actuarial.Services
{
    public record ModelSerializer<T>
    {

        private readonly IEnumerable<Dictionary<String, FieldInfo>> modelDictionary = new List<Dictionary<String, FieldInfo>>();


        public ModelSerializer(T[] modelObjects, String[] fieldNames) => this.modelDictionary = SerializedObjects(modelObjects, fieldNames).Result;


        protected async Task<IEnumerable<Dictionary<string, FieldInfo>>> SerializedObjects(T[] objects, String[] fieldNames)
        {
            List<Task<Dictionary<String, FieldInfo>>> dictionaryList = new();

            foreach (T objectType in objects)
            {

                dictionaryList.Add(GetSerializedObjectAsync(modelObject: objectType!.GetType(), fieldNames));
            }

            return await Task.WhenAll(dictionaryList);
        }

        protected async Task<Dictionary<String, FieldInfo>> GetSerializedObjectAsync(Type modelObject, String[] fieldNames)
        {
            List<Task<Tuple<string, FieldInfo>>> getfields = new List<Task<Tuple<string, FieldInfo>>>();

            Dictionary<String, FieldInfo> dict = new();

            fieldNames.ToList().ForEach(fieldName => getfields.Add(GetFieldName(modelObject, fieldName)));

            _ = await Task.WhenAll(getfields);

            return await Task.FromResult(getfields.ToDictionary(x => x.Result.Item1, x => x.Result.Item2));

        }

        protected Task<Tuple<string, FieldInfo>> GetFieldName(Type modelObject, String fieldName)
        {
            FieldInfo field = modelObject.GetField(fieldName)!;
            Tuple<string, FieldInfo> fieldtuple = new(fieldName, field);
            return Task.FromResult(fieldtuple);
        }

           
    }
}
