using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DEMO_03
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }
    }
}

Тестовый пример #	TC_DP_1	расшифровывается: TestCase_DeleteProduct_x
Приоритет тестирования	средний	бизнес-правило
Заголовок/название теста	Удаление товара без продаж и дополнительных товаров	
Краткое изложение теста	Товар должен без ошибок удалиться из таблицы товаров	
Этапы теста	1. Очистить таблицы продаж, дополнительных товаров, дополнительных картинок и товаров. 2. Добавить тестовый товар в таблицу Products
3. Вызвать метод удаления товара
4. Проверить наличие удаленной записи в таблице	
Тестовые данные	Название: Моторное масло Motor Oil KE900-90042-R
Изображение: Товары автосервиса\8FE07916.jpg
Производитель: Nissan
Активен: да
Цена: 2060  Тут нужно вставить содержимое любой записи из products_a_import
Ожидаемый результат	Запись должна быть удалена из таблицы без ошибок и исключений	
Фактический результат	Запись удалена	
Статус	зачет	
Предварительное условие	В базу должны быть загружен тестовый продукт	
Постусловие	Таблица товаров должна быть пустой	
Примечания/комментарии	Т.к. мы добавили только товар без продаж и дополнительных товаров, то ошибок в принципе быть не может ни по вине кода ни по ограничениям базы

git add .

git commit -m ""
git push heroku master(main)

public class Analytics
{
    public List<DateTime> PopularMonths(List<DateTime> dates)
    {
        return dates;
    }
}
