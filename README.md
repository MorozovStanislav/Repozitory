# Информационная система мастерской по пошиву обуви
## Содержание
[Введение](#introduction)

1 [Описание предметной области](#PredmetnayaOblast)

2 [Анализ существовующих решений](#AnalizResheniy)

3 [ Пример програмного кода](#Programma)

3.1 [Проектирование системы](#проектирование_системы)

3.2 [Реализация системы](#реализация_системы)

4 [Тестирование](#Test)

[Заключение](#Itog)

[Список Литературы](#Literatura)


<a name = "introduction"/>

## Введение

Для данного проекта была выбрана тема информационная система "Обувного магазина". Цель информационной системы: повышение оперативности и качества процесса отслеживания купли-продажи обуви.

<a name = "PredmetnayaOblast"/>

## 1 Описание предметной области
Предметная область - обувной магазин, а именно мастерская по пошиву обуви.

Функциональные возможности обувной мастерской:
- производство эксклюзивной обуви по индивидуальным заказам;
- инструментарий и мастерство: в ремонте обуви используют - профессиональное немецкое, итальянское обрудование и обувные комплектующие передовых производителей.
Превосходно сочетая теорию и практику, специалисты обувной мастерской всегда готовы оказать вам помощь с оформлением индивидуального заказа по пошиву обуви;
- выполняет заказы по пошиву эксклюзивной женской и мужской обуви, любых моделей из натуральной кожи и материалов передовых производителей.
Индивидуальный пошив мужской и женской обуви любых размеров, по вашим меркам.[<sup>[1]</sup>](#sourse_1)

Модели:
Индивидуальный подход позволяет воплощать пожелания заказчика предельно точно. В ассортименте обувсной мастерской доступны любые виды обувных кож из КРС, Рептилий и др. Любая фурнитура, - стразы, метало фурнитура, так же можно декорировать кожей или воспользоваться бижутерией.

Подошва:
Подошва из натуральной кожи защищенная профилактикой создают климатический комфорт в процессе эксплуатации обуви. Любые каблуки, от заводских из винила или металла до наборных из кожи по старинной и уже давно зарекомендовавшей себя технологии.

Предметная область включает в себя следующие разделы: "Менеджер", "Заказчик", "Поставщик", "Дизайнер".  Так как мастерская занимается исключительно пошивом на заказ, то прежде чем совершить покупку, заказчик высказывает свои пожелания по поводу обуви, например: какая должна быть модель, из какого материала будет изготовлена, снятие мерок и др. Только после этого происходит оплата и заказ поступает в разработку. Создаётся дизайн-проект по пошиву обуви, где дизайнер определяется с материалом. Но тут мастерская сталкивается с проблемой, что обуви из заказанного материала сшить нельзя, так как этот материал отсутствует в мастерской. Эту проблему можно решить. Менеджер отправляет заказ на нужные материалы. Заказ материалов поступает поставщику, который в свою очередь делает запрос на слад, где хранятся материалы, далее он осуществляет отправку всех необходимых материалов для изготовления обуви в мастерску. При поступлении материала на производство, осуществляется пошив дизайн-проекта, и далее происходит его нумерация и отправка на склад, где хранятся остальные проекты. Поставщик по индивидуальному номеру пары, забирает и производит её отправку. Заказчик получает обувь по номеру посылки и если ему не понравится пара, то он оставляет отзыв, и ждёт пока менеджер проанализирует его и вернёт денежные средства.


<a name = "AnalizResheniy"/>

## 2 Анализ существовующих решений


<a name = "Programma"/>

## 3 Разработка системы

<a name= "проектирование_системы"/>
### 3.1 Проектирование системы

Разработка информационной системы начинается с проектирования диаграммы вариантов использования (use-case diagram), отображающей действующие лица данной системы (рисунок 1):
менеджер, поставщик, дизайнер, заказчик.
<p align="center">
<img src="https://user-images.githubusercontent.com/91194323/146272854-ef3c182a-d6bb-4616-8ab1-fdec2ecaa99c.png"></p>
<p align="center">Рисунок 1 - Диаграмма вариантов использования</p>  

На основе данной диаграммы разрабатывается диаграмма потоков данных (DFD - Data Flow Diagrams), на которой изображено, как процессы и хранилища связаны с потоками данных. (рисунок 2).
<p align="center">
<img src="https://user-images.githubusercontent.com/91194323/146273041-dab1e85e-24be-4f32-8249-2856595227bf.png"></p>
<p align="center">Рисунок 2 - Диаграмма потоков данных</p>  

### 3.2 Реализация системы <a name="реализация_системы"/>

На основе DFD проектируется схема «сущность-связь» (ER-диаграмма), где показаны сущности и связи между ними (рисунок 3).
<p align="center">
<img src="https://user-images.githubusercontent.com/91194323/146273534-30e786c7-c5dc-48dd-b826-db7923eb1643.png"></p>
<p align="center">Рисунок 3 - Диаграмма «сущность-связь»</p>  

На основании ER диаграммы для каждой сущности был создан класс с указанием свойств, параметров и типов данных. Примеры классов Дизайн-проект и Материалы. (листинг 1 и листинг 2).
Листинг 1 - Класс "Дизайн-проекта"
```csharp
   public class DesignProject
    {
        public int DesignProjectId { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string LastName { get; set; }

        public int Сonstruction { get; set; }

        public string Materials { get; set; }
    }
```
Листинг 2 - Класс "Материалы"
```csharp
public class Materials
    {
        public int MaterialsId { get; set; }

        public string NameMaterial { get; set; }

        public int Count { get; set; }
    }
```
Затем реализуем контроллеры с методами CRUD (create, read, update, delete) и общее хранилище.
Пример контролёра для класса "Дизайн-проект" (листинг 3).
Листинг 3 - Контролёр для класса "Дизайн-проект"
```csharp
namespace Repozitory.Controllers
{
    [ApiController]
    [Route("/DesignProject")]
    public class DesignProjectController : ControllerBase
    {
        [HttpPost("Create")]
        public void Create(DesignProject designProject)
        {
            DesignProjectStorage.Create(designProject);
        }

        [HttpGet("Read")]
        public DesignProject Read(int designProjectId)
        {
            return DesignProjectStorage.Read(designProjectId);
        }

        [HttpPut("Update")]
        public DesignProject Update(int id, DesignProject designProject)
        {
            return DesignProjectStorage.Update(id, designProject);
        }

        [HttpDelete("Delete")]
        public bool Delete(int designProjectId)
        {
            return DesignProjectStorage.Delete(designProjectId);
        }
    }
}
```
Также разрабатываем репозитории для каждого класса.
Пример репозитория для класса "Дизайн-проект" (листинг 4).
Листинг 4 - Репозиторий для класса "Дизайн-проект"
```csharp
     public class DesignProjectStorage
    {
        private static Dictionary<int, DesignProject> DesignProjects { get; } = new Dictionary<int, DesignProject>();

        public static void Create(DesignProject designProject)
        {
            DesignProjects.Add(designProject.DesignProjectId, designProject);
        }

        public static DesignProject Read(int designProjectId)
        {
            return DesignProjects[designProjectId];
        }

        public static DesignProject Update(int designProjectId, DesignProject newDesignProject)
        {
            DesignProjects[designProjectId] = newDesignProject;
            return DesignProjects[designProjectId];
        }

        public static bool Delete(int designProjectId)
        {
            return DesignProjects.Remove(designProjectId);
        }
    }
```
Пример общего хранилища (листинг 5).
Листинг 5 - Общее хранилище
```csharp
 public static class Storage
    {
        public static CustomerStorage CustomerStorage { get; } = new CustomerStorage();
        public static DesignProjectStorage DesignProjectStorage { get; } = new DesignProjectStorage();
        public static MaterialOrdersStorage MaterialOrdersStorage { get; } = new MaterialOrdersStorage();
        public static MaterialsStorage MaterialsStorage { get; } = new MaterialsStorage();
        public static MaterialWarehouseStorage MaterialWarehouseStorage { get; } = new MaterialWarehouseStorage();
        public static PackageStorage PackageStorage { get; } = new PackageStorage();
        public static ProviderStorage ProviderStorage { get; } = new ProviderStorage();
        public static ReviewsStorage ReviewsStorage { get; } = new ReviewsStorage();
        public static ShoeOrdersStorage ShoeOrdersStorage { get; } = new ShoeOrdersStorage();
        public static ShoesStorage ShoesStorage { get; } = new ShoesStorage();
        public static ShoeWarehouseStorage ShoeWarehouseStorage { get; } = new ShoeWarehouseStorage();
        public static StoreAccountStorage StoreAccountStorage { get; } = new StoreAccountStorage();
        public static WishesStorage WishesStorage { get; } = new WishesStorage();
    }
``` 

<a name = "Test"/>

## 4 Тестирование
После компиляции программы, открывается страница Swagger UI со списком сущностей и операций над ними (рисунок 4).
<p align="center">
<img src="https://user-images.githubusercontent.com/91194323/146276433-e3f7aa73-b6b0-4167-8ccc-9e4fc2ec04ff.png"></p>
<p align="center">Рисунок 4 - Cтраница Swagger UI</p> 

Работа основных методов CRUD на примере сущности Customer (рисунок 5).
<p align="center">
<img src="https://user-images.githubusercontent.com/91194323/146276810-31216e68-5efa-4c08-84c4-488b7504ea9a.png"></p>
<p align="center">Рисунок 5 -Проверка работы методов CRUD</p> 

Create позволяет добавлять новые строки в вашу таблицу (рисунок 6).
<p align="center">
<img src="https://user-images.githubusercontent.com/91194323/146278730-e4f7e4a4-5f9d-4d92-b190-b053a30a5f03.png"></p>
<p align="center">Рисунок 6 - Окно метода создания</p> 

Вводим необходимые данные и после успешного выполнения операции создания, получаем (рисунок 7).
<p align="center">
<img src="https://user-images.githubusercontent.com/91194323/146278789-28be328f-1d40-41ec-91b9-78740ae12ecb.png"></p>
<p align="center">Рисунок 7 - Результат выполнения операции создания</p> 

Функция Read позволяет извлекать определённые записи и считывать их значения.
Покажем на примере как это работает (рисунок 8 - 10).
<p align="center">
<img src="https://user-images.githubusercontent.com/91194323/146278413-e1b85114-48ab-4f8d-8e87-0a99b6311fda.png"></p>
<p align="center">Рисунок 8 - Окно функции чтения</p> 

<p align="center">
<img src="https://user-images.githubusercontent.com/91194323/146278865-906aeb7d-8bf4-45ca-8cef-aceecab7c01e.png"></p>
<p align="center">Рисунок 9 - Окно ввода значения для поиска</p> 

<p align="center">
<img src="https://user-images.githubusercontent.com/91194323/146279270-32c69909-484f-4f61-afd5-a92d717eb12d.png"></p>
<p align="center">Рисунок 10 - Окно результата вывода</p> 


Редактирование записи (рисунок 11). Используется для изменения существующих записей в базе данных.
<p align="center">
<img src="https://user-images.githubusercontent.com/91194323/146279620-d390a05d-9d22-4467-b09c-6ded5a51443d.png"></p>
<p align="center">Рисунок 11 - Окно метода изменения</p> 

Измениение информации. Ввод новых данных (рисунок 12).
<p align="center">
<img src="https://user-images.githubusercontent.com/91194323/146279750-b79bb4f3-4588-45b6-9cae-7c18b3cca1a0.png"></p>
<p align="center">Рисунок 12 - Работа с методом обновления</p> 

После выполнения операции выводится изменённая информация (рисунок 13).
<p align="center">
<img src="https://user-images.githubusercontent.com/91194323/146279864-68208def-84a4-49f0-b6b9-eb85e1b6ee8f.png"></p>
<p align="center">Рисунок 13 - Результат выполнения операции обновления</p> 

Delete - используется для удаления записи. Эта операция может принемать только два значения "true" или "false" (рисунок 14).
<p align="center">
<img src="https://user-images.githubusercontent.com/91194323/146280148-7ca83d17-be94-47fc-9aa2-d948bf02c550.png"></p>
<p align="center">Рисунок 14 - Окно метода удаления</p> 

Выполняем операцию удаления (рисунок 15).
<p align="center">
<img src="https://user-images.githubusercontent.com/91194323/146280350-96c79569-f23d-44b8-a0ee-b6c03c45d1d2.png"></p>
<p align="center">Рисунок 15 - Работа с методом удаления</p> 

Результат выполнения (рисунок 16).
<p align="center">
<img src="https://user-images.githubusercontent.com/91194323/146280483-53408dc8-4516-48a7-a9e4-7c0a7af93bca.png"></p>
<p align="center">Рисунок 16 - Результат выполнения метода удаления</p> 

Сделаем проверку на существование удалённой записи (рисунок 17).
<p align="center">
<img src="https://user-images.githubusercontent.com/91194323/146280720-58c4f094-d38a-4abc-949e-21aef137a3e5.png"></p>
<p align="center">Рисунок 17 - Проверка</p> 


<a name = "Itog"/>

## Заключение

<a name = "Literatura"/>

## Список использованных источников
<a name="sourse_1">
[1] Виды обувных мастерских и их продукции [электронный ресурс] // "ОБУВНАЯ МАСТЕРСКАЯ" - Режим доступа: https://www.lelab.ru/support/19.html, свободный (дата обращения 02.12.2021).
