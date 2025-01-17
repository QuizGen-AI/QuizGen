### Технологічний стек проекту QuizGen AI

1. **ADO.NET**

Використання: ADO.NET забезпечить пряме підключення до бази даних для виконання операцій CRUD (створення, читання, оновлення, видалення) для зберігання та отримання інформації про користувачів, результати тестів, статистику прогресу та налаштування. Це дозволить безпосередньо працювати з базами даних SQL, забезпечуючи ефективний доступ до даних.

2. **Entity Framework (EF)**

Використання: Entity Framework надасть високорівневий доступ до даних та об’єктно-реляційне відображення (ORM), що спростить роботу з базою даних. EF допоможе у створенні моделей для зберігання інформації про питання, теми, результати тестів та інших сутностей, забезпечуючи швидкий доступ і прості маніпуляції з даними без необхідності писати складні SQL-запити.

3. **WPF (Windows Presentation Foundation)**

Використання: WPF буде основою для створення користувацького інтерфейсу. За допомогою WPF буде створено інтуїтивно зрозумілий, сучасний і адаптивний інтерфейс програми. Можливості WPF для створення багатих графічних елементів та анімацій покращать користувацький досвід, забезпечуючи комфортне використання як для окремих користувачів, так і в мультиплеєрних режимах.

4. Інтеграція з OpenAI API або локальна модель через Ollama

Використання: Для генерації тестових питань на основі обраних тем (математика, історія, програмування та інші) буде інтегровано штучний інтелект. Для цього будуть використовуватися два варіанти:

- OpenAI API: Використання зовнішнього API від OpenAI для генерації запитань у реальному часі. Користувачам буде запропоновано вказати API ключ.

- Локальна модель через Ollama: У разі потреби використання локальної моделі штучного інтелекту, буде інтегровано ПЗ Ollama, яке дозволяє запускати моделі AI на локальному комп’ютері без необхідності підключення до хмарних сервісів. Це забезпечить повну автономність для користувачів, які не мають постійного доступу до Інтернету.
