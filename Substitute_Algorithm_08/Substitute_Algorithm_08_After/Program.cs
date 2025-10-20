string FoundPerson(string[] people)
{
    //  Thêm mảng chứa các tên cần tìm — thay cho nhiều câu lệnh if trước đó
    string[] candidates = { "Don", "John", "Kent" };

    //  Thay toàn bộ vòng lặp bằng 1 dòng LINQ:
    // FirstOrDefault(...) → trả về phần tử đầu tiên trong danh sách people 
    // thỏa điều kiện bên trong (p => candidates.Contains(p))
    // Nếu không có ai thỏa, kết quả sẽ là null
    //  string.Empty → nếu null thì trả về chuỗi rỗng (đảm bảo không lỗi)
    return people.FirstOrDefault(p => candidates.Contains(p)) ?? string.Empty;
}
