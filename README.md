![SPT](https://img.shields.io/badge/SPT-5.0.0-blue?style=flat-square)
![EFT](https://img.shields.io/badge/EFT-1.1.5.1.47510-lightgrey?style=flat-square)
![BepInEx](https://img.shields.io/badge/BepInEx-6.0.0--be.788-orange?style=flat-square)
![IL2CPP](https://img.shields.io/badge/Runtime-IL2CPP-purple?style=flat-square)
![.NET](https://img.shields.io/badge/.NET-6.0-512BD4?style=flat-square)
![License](https://img.shields.io/badge/License-Custom%20%2F%20SPT--only-red?style=flat-square)
![Status](https://img.shields.io/badge/Status-Working-brightgreen?style=flat-square)


# InventoryPatch SPT 5.0
***InventoryPatch*** - BepInEx‑плагин для SPT 5.0, реализующий использование медицины из рюкзака и контейнеров.

## Возможности:
- Предметы из рюкзака и контейнеров доступны для бинда на горячие клавиши
- Работает с медициной, гранатами, едой, сигнальными ракетами
- Минимальный след — два Harmony prefix-патча, ничего лишнего
- Совместим с другими модами на инвентарь

## Установка:
Скопируй InventoryPatch.dll в BepInEx/plugins/

## Известные ограничения:
При снятии или передаче рюкзака бинды на предметы внутри сбрасываются — это ограничение движка EFT, не мода. Назначьте бинды заново после экипировки.

## Требования:
SPT 5.0
BepInEx 6.0.0-be.788+ (IL2CPP)

## Технические детали:
Мод обходит ограничение Harmony IL2CPP. Вместо этого патчатся два не-generic метода-проверки, которые игра вызывает для каждого предмета при поиске достижимых и биндабельных вещей. Prefix возвращает true и пропускает оригинальный метод — все предметы проходят проверку.

## Автор:
zzzNIKOzzz

## Оригинальная идея:
[Use Items Anywhere](https://sp-mod.com/mod/2386/use-items-anywhere) мод  от Cj  (версия для SPT 4.1.6 / Mono)

## Лицензия:
MIT — делай что хочешь, просто не забудь упомянуть автора.
<img width="2560" height="1440" alt="2026-10-06_22-52-30" src="https://github.com/user-attachments/assets/4a961de4-00be-44eb-b80d-9eab82aa9aba" />
