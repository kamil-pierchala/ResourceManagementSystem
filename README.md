# Resource Management System (RMS)

## Opis Projektu
**Resource Management System** to kompleksowy, rozproszony system przeznaczony do efektywnego zarządzania zasobami firmy. Projekt został zrealizowany w architekturze wielowarstwowej z naciskiem na bezpieczeństwo i automatyzację procesów.

---

## Architektura systemu
System składa się z czterech głównych modułów widocznych w rozwiązaniu:

* **RMS.API**: Backend stworzony w technologii ASP.NET Core Web API, obsługujący logikę biznesową i komunikację z bazą danych.
* **RMS.Client.WPF**: Desktopowa aplikacja kliencka stworzona w technologii WPF (C#/XAML).
* **RMS.SyncService**: Autonomiczna usługa typu Worker Service, działająca w tle i monitorująca stany zasobów.
* **RMS.Tests**: Zestaw testów jednostkowych xUnit weryfikujących poprawność mechanizmów systemowych.

---

## Kluczowe funkcjonalności
* **Bezpieczeństwo**: Implementacja autoryzacji opartej na tokenach **JWT (JSON Web Token)**.
* **Automatyzacja CI/CD**: Skonfigurowany potok **GitHub Actions**, który automatycznie buduje projekt i uruchamia testy przy każdym Pull Request.
* **Testy Jednostkowe**: Zautomatyzowana weryfikacja modeli i logiki biznesowej przy użyciu frameworka xUnit.
* **Background Processing**: Wykorzystanie usługi SyncService do przetwarzania zadań bez blokowania interfejsu użytkownika.

---

## TechStack:
* **Platforma**: .NET 8.0
* **Baza danych**: Microsoft SQL Server
* **DevOps**: GitHub Actions
* **Testowanie**: xUnit
* **Interfejs**: WPF - Windows Presentation Foundation

---

## Wydania 
Aktualna stabilna wersja: **v1.0**.
Zapewnia ona pełną funkcjonalność zgodnie z założeniami projektu i pomyślnie przechodzi wszystkie testy automatyczne.
