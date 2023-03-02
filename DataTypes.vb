

Module DataTypes
    Sub Main(args As String())
        'Dim - ключевое слово, которое означачает, что мы объявляем переменную
        ' dec, dbl, sng - имена переменных, имя может быть любым
        'As - ключевое слово, которое означает, что дальше будет объявлен тип данных
        'после As следует тип данных (ключ Visual Basic data types)
        'Здесь смотрим числа с плавающей точкой
        Dim dec As Decimal
        Dim dbl As Double
        Dim sng As Single
        Dim rub As Integer
        Dim kop As Integer
        dec = 123456789123456789
        dbl = 123456789123456789
        sng = 123456789.00001
        'Console.WriteLine(dec)
        'Console.WriteLine(dbl)
        'Console.WriteLine(sng)
        Dim input As Integer
        Console.Write("Введите сумму в копейках: ")
        input = Console.ReadLine()
        sng = input / 100
        rub = input / 100
        kop = input Mod 100
        Console.WriteLine("{0} копеек = {1} рублей ", input, sng)
        Console.WriteLine("{0} копеек = {1} рублей {2} копеек", input, rub, kop)
    End Sub
End Module