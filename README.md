# CalendarConvertor

Written in C# is a Console App that Converts Solar Hijri calendar date to AD(Anno Domini) calendar date

#تبدیل_تاریخ_شمسی_به_میلادی

#تبدیل_تاریخ_شمسی

#هجری_شمسی_به_میلادی


روش محاسبه:

اگر می‌خواهیم تاریخ شمسی را به میلادی تبدیل کنیم ابتدا باید روزهای سپری شده از مبدا تاریخ شمسی تا کنون را حساب کنیم و آن را به اضافه‌‌ی ۲۲۶۸۹۹ بکنیم. عدد به دست آمده تعداد روزهای گذشته از ابتدای تاریخ میلادی تا کنون است و با استفاده از آن می‌توانیم تاریخ میلادی را حساب کنیم. برای تبدیل تاریخ میلادی به شمسی همین کار را باید برعکس انجام بدهیم و عدد ۲۲۶۸۹۹ را باید از تعداد روزهای تاریخ میلادی کم بکنیم و در این قسمت عدد به دست آمده تاریخ شمسی است.

همین روش نیز برای تبدیل تاریخ قمری به شمسی و برعکس نیز قابل استفاده است. ولی در این مورد دیگر عددی که باید اضافه یا کم بشود ۲۲۶۸۹۹ نیست.

شاید از خود بپرسید که عدد ۲۲۶۸۹۹ را از کجا به دست آورده‌‌ام. برای به دست آوردن این عدد باید تاریخ شمسی و میلادی یک روز را در اختیار داشته باشید.

به عنوان مثال ۱۳/۴/۱۳۸۳ شمسی طبق تقویم برابر ۳/۷/۲۰۰۴ میلادی است. کاری که باید الا بکنیم این است که این دو تاریخ را به روز تبدیل کنیم و در این تبدیل باید تعداد سال‌های کبیسه‌ای که این دو تاریخ پشت سر گذاشته‌اند نیز فراموش نکنیم. برای اینکه تعداد سال‌های کبیسه را در دو تقویم میلادی و شمسی بخواهیم محاسبه کنیم باید ۱۳۸۲ را برای تقویم شمسی و ۲۰۰۳ را برای تقویم میلادی تقسیم بر ۴ کنیم. خارخ قسمت این دو تقسیم به ترتیب تعداد سال‌های کبیسه‌ی تقویم شمسی و میلادی است که از ابتدای شروع به کار این تقویم‌ها تا کنون پشت سر گذاشته‌اند. البته این اعداد مطابق واقعیت نیستند! ولی به محاسبات ما اشکالی وارد نمی‌کنند.

در تقسیم ۱۳۸۲ بر ۴ خارج قسمت برابر ۳۴۵ می‌شود و این عدد برای تقویم میلادی برابر ۵۰۰ است.

خب پس تا کنون بر اساس تقویم شمسی ۳۴۵ سال کبیسه بوده و بر اساس تقویم میلادی ۵۰۰ سال برابر سال کبیسه بوده‌اند. 
(البته همان طور که دید به کبیسه بودن سالی که در آن هستیم هنوز توجهی نکردیم.) خب برگردیم به مساله‌ی خودمان که می‌خواستیم دو تاریخ ۱۳/۴/۱۳۸۳ و ۳/۷/۲۰۰۴ به روز تبدیل کنیم.

برای این کار باید از عدد سال یکی کم کرده و در ۳۶۵ ضرب کنیم. و از عدد ماه نیز باید یکی کم کرده و بر اساس نوع تقویم باید عدد ماه را ضرب در عدد خاصی بکنیم. مثلا وقتی در تاریخ شمسی از عدد ماه یکی کم کنیم حاصل ۳ می‌شود. همان طور که می‌دانید در تقویم شمسی ۳ ماه اول سال ۳۱ روز دارند، پس ۳ را در ۳۱ ضرب می‌کنیم. ولی در تاریخ شمسی وقتی از ۷ یکی کم کینم برابر ۶ می‌شود. خب باید در این مورد ببینیم که ۶ ماه اول سال میلادی چند روزه هستند.

ماه اول میلادی = ۳۱ روز

ماه دوم میلادی = ۲۸ روز (در سال کبیسه ۲۹ روز)

ماه سوم میلادی = ۳۱ روز

ماه چهارم میلادی = ۳۰ روز

ماه پنجم میلادی = ۳۱ روز

ماه ششم میلادی = ۳۰ روز

ماه هفتم میلادی = ۳۱ روز

ماه هشتم میلادی = ۳۱ روز

ماه نهم میلادی = ۳۰ روز

ماه دهم میلادی = ۳۱ روز

ماه یازدهم میلادی = ۳۰ روز

ماه داوزدهم میلادی = ۳۱ روز

طبق جدول بالا ۶ ماه اول سال ۲۰۰۴ میلادی برابر ۱۸۲ روز می‌باشد. (فراموش نکنید که سال ۲۰۰۴ سال کبیسه است.) خب تا حالا عدد سال و ماه را به روز تبدیل کردیم و این دو عدد را باید به اضافه‌ی عدد روز کنیم و در آخر به اضافه‌ی تعداد سال‌های کبیسه گذشته بکنیم. داریم

A = (1382*365)+(3*31)+13+345 = 504881 

B= (2003*365)+(31+29+31+30+31+30)+3+500=731780 

B-A = 226899 

با محاسبات فوق خواستم نشان بدهم که عدد ۲۲۶۸۹۹ که در اول بحث گفتیم را از کجا آوردیم. همان طور که احتمالا تا حالا فهمیدید این عدد (۲۲۶۸۹۹) تفاوت مبداهای دو تقویم میلادی و شمسی به روز هستند.

حال مثالی می‌زنم برای تبدیل تاریخ شمسی به تاریخ میلادی. فرض کنید که می‌خواهیم که تاریخ ۱۵/۴/۱۳۸۳ شمسی را به تاریخ میلادی نظیر آن تبدیل کنیم. در ابتدا باید این تاریخ را به روز تبدیل کنیم. طبق روش گفته شده در بالا می‌نویسیم:
 
C =[(1383-1)*365]+[(4-1)*31]+15+345 = 504883 

خب این عدد را باید به اضافه‌ی ۲۲۶۸۹۹ بکنیم:

۵۰۴۸۸۳+۲۲۶۸۹۹ = ۷۳۱۷۸۲

حال باید ۷۳۱۷۸۲ را به تاریخ میلادی متناظر آن تبدیل کنیم.
ابتدا باید تعدا سال‌های کبیسه‌ی تقویم میلادی را از این عدد کنیم، در بالا دیدیم که تقویم میلادی تا کنون ۵۰۰ سال کبیسه را پشت سر گذاشته است.

۷۳۱۷۸۲-۵۰۰=۷۳۱۲۸۲

حال ۷۳۱۲۸۲ را بر ۳۶۵ تقسیم می‌کنیم و خارج قسمت آن را به اضافه‌ی یک می‌کنیم و عدد به دست آمده عدد سال است:

۷۳۱۲۸۲ / ۳۶۵ = ۲۰۰۳ ۲۰۰۳ + ۱= ۲۰۰۴

باقیمانده‌ی تقسیم فوق برابر ۱۸۷ می‌باشد. حال با استفاده از جدول تعداد روز‌های تقویم میلادی شروع می‌کنیم از ۱۸۷ کم می‌کنیم و باز هم فراموش نمی‌کنیم که سال ۲۰۰۴ میلادی سال کبیسه است :

۱۸۷-۳۱=۱۵۶

۱۵۶-۲۹=۱۲۷

۱۲۷-۳۱=۹۶

۹۶-۳۰=۶۶

۶۶-۳۱=۳۵

۳۵-۳۰=۵

خب تفریق‌های فوق را تا جایی ادامه می‌دهیم که عدد به دست آمده کمتر از تعداد روزهای یک ماه باشند. در بالا ۶ مرحله تفریق انجام دهیم به عدد ۶ باید یک بیافزاییم تا تعداد ماه‌ها به دست آید. و عدد ظاهر شده در تفریق آخر نیز برابر عدد روز می‌باشد. پس با محاسبات فوق دیدیم که تاریخ ۱۵/۴/۱۳۸۳ شمسی برابر ۵/۷/۲۰۰۴ است.

