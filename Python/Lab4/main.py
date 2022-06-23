import Funcs

dates = Funcs.DatesGenerate()
times = Funcs.TimesGenerate()

print("\nInitial dates:")
Funcs.ListOutput(dates)
print("\nInitial times:")
Funcs.ListOutput(times)

dates_like_time = Funcs.DatesLikeTime(dates)
print("\nDates that can be interpreted like time:")
Funcs.ListOutput(dates_like_time)

Funcs.ChangeDates(dates)
Funcs.ChangeTimes(times)

print("\nChanged dates:")
Funcs.ListOutput(dates)
print("\nChanged times:")
Funcs.ListOutput(times)
