# Информационная система мастерской по пошиву обуви
## Содержание
[Введение](#introduction)

[1 Описание предметной области](#PredmetnayaOblast)

[2 Анализ существовующих решений](#AnalizResheniy)

[3 Пример програмного кода](#Programma)

3.1 [Проектирование системы](#проектирование системы)

3.2 [Реализация системы](#реализация системы)

[4 Тестирование](#Test)

[Заключение](#Itog)

[Список Литературы](#Literatura)


<a name = "introduction"/>

## Введение

Для данного проекта была выбрана тема информационная система "Обувного магазина". Цель информационной системы: повышение оперативности и качества процесса отслеживания купли-продажи обуви.

<a name = "PredmetnayaOblast"/>

## 1 Описание предметной области
Предметная область - обувной магазин, а именно мастерская по пошиву обуви.

Функциональные возможности обувной мастерской:
- Производство эксклюзивной обуви по индивидуальным заказам.
- Инструментарий и мастерство: в ремонте обуви используют - профессиональное немецкое, итальянское обрудование и обувные комплектующие передовых производителей.
Превосходно сочетая теорию и практику, специалисты обувной мастерской всегда готовы оказать вам помощь с оформлением индивидуального заказа по пошиву обуви.
- Выполняет заказы по пошиву эксклюзивной женской и мужской обуви, любых моделей из натуральной кожи и материалов передовых производителей.
Индивидуальный пошив мужской и женской обуви любых размеров, по вашим меркам.

Модели:
Индивидуальный подход позволяет воплощать пожелания заказчика предельно точно. В ассортименте обувсной мастерской доступны любые виды обувных кож из КРС, Рептилий и др. Любая фурнитура, - стразы, метало фурнитура, так же можно декорировать кожей или воспользоваться бижутерией.

Подошва:
Подошва из натуральной кожи защищенная профилактикой создают климатический комфорт в процессе эксплуатации обуви. Любые каблуки, от заводских из винила или металла до наборных из кожи по старинной и уже давно зарекомендовавшей себя технологии.

Предметная область включает в себя следующие разделы: "Менеджер", "Заказчик", "Поставщик", "Дизайнер".  Так как мастерская занимается исключительно пошивом на заказ, то прежде чем совершить покупку, заказчик высказывает свои пожелания по поводу обуви, например: какая должна быть модель, из какого материала будет изготовлена, снятие мерок и др. Только после этого происходит оплата и заказ поступает в разработку. Создаётся дизайн-проект по пошиву обуви, где дизайнер определяется с материалом. Но тут мастерская сталкивается с проблемой, что обуви из заказанного материала сшить нельзя, так как этот материал отсутствует в мастерской. Эту проблему можно решить. Менеджер отправляет заказ на нужные материалы. Заказ материалов поступает поставщику, который в свою очередь делает запрос на слад, где хранятся материалы, далее он осуществляет отправку всех необходимых материалов для изготовления обуви в мастерску. При поступлении материала на производство, осуществляется пошив дизайн-проекта, и далее происходит его нумерация и отправка на склад, где хранятся остальные проекты. Поставщик по индивидуальному номеру пары, забирает и производит её отправку. Заказчик получает обувь по номеру посылки и если ему не понравится пара, то он оставляет отзыв, и ждёт пока менеджер проанализирует его и вернёт денежные средства.


<a name = "AnalizResheniy"/>

## 2 Анализ существовующих решений


<a name = "Programma"/>

## 3 Разработка системы

### 3.1 Проектирование системы <a name="проектирование системы"></a>

Разработка информационной системы начинается с проектирования диаграммы вариантов использования (use-case diagram), отображающей действующие лица данной системы (см. рисунок 1):
менеджер, поставщик, дизайнер, заказчик.
<p align="center">
<img src="https://user-images.githubusercontent.com/91194323/146272854-ef3c182a-d6bb-4616-8ab1-fdec2ecaa99c.png"></p>
<p align="center">Рисунок 1 - Диаграмма вариантов использования</p>  

На основе данной диаграммы разрабатывается диаграмма потоков данных (DFD - Data Flow Diagrams), на которой изображено, как процессы и хранилища связаны с потоками данных. (см. рисунок 2).
<p align="center">
<img src="https://user-images.githubusercontent.com/91194323/146273041-dab1e85e-24be-4f32-8249-2856595227bf.png"></p>
<p align="center">Рисунок 2 - Диаграмма потоков данных</p>  

### 3.2 Реализация системы <a name="реализация системы"></a>

На основе DFD проектируется схема «сущность-связь» (ER-диаграмма), где показаны сущности и связи между ними (см. рисунок 3).
<p align="center">
<img src="https://user-images.githubusercontent.com/91194323/146273534-30e786c7-c5dc-48dd-b826-db7923eb1643.png"></p>
<p align="center">Рисунок 3 - Диаграмма «сущность-связь»</p>  

На основании ER диаграммы для каждой сущности был создан класс с указанием свойств, параметров и типов данных. Примеры классов Дизайн-проект и Материалы:
Пример класса "Дизайн-проект"
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
Пример класса "Материалы"
```csharp
public class Materials
    {
        public int MaterialsId { get; set; }

        public string NameMaterial { get; set; }

        public int Count { get; set; }
    }
```
Затем реализуем контроллеры с методами CRUD (create, read, update, delete) и общее хранилище.
Пример контролёра для класса "Дизайн-проект"
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
Пример репозитория для класса "Дизайн-проект"
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
Пример общего хранилища
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


<a name = "Itog"/>

## Заключение


<a name = "Literatura"/>

## Список использованных источников
