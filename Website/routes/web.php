<?php

use App\Http\Controllers\AuthController;
use App\Http\Controllers\CartController;
use App\Http\Controllers\CheckoutController;
use App\Http\Controllers\HomeController;
use App\Http\Controllers\OpenAIController;
use Illuminate\Support\Facades\Route;

/*
|--------------------------------------------------------------------------
| Web Routes
|--------------------------------------------------------------------------
|
| Here is where you can register web routes for your application. These
| routes are loaded by the RouteServiceProvider and all of them will
| be assigned to the "web" middleware group. Make something great!
|
*/

Route::get('/cart', [CartController::class, 'index'])->name('cart.index');
Route::get('/cart/{id}', [CartController::class, 'addToCart'])->name('cart.add');
Route::get('/cart/delete/{id}', [CartController::class, 'deleteCart'])->name('cart.delete');
Route::post('/cart/update', [CartController::class, 'updateCart'])->name('cart.update');
Route::get('/', [HomeController::class, 'index'])->name('home.index');
Route::get('/checkout', [CheckoutController::class, 'index'])->name('checkout.index');
Route::post('/checkout', [CheckoutController::class, 'order'])->name('checkout.order');
Route::post('/voucher', [CheckoutController::class, 'useVoucher'])->name('checkout.voucher');
Route::get('/register', [AuthController::class, 'registerGet'])->name('register.index');
Route::post('/register', [AuthController::class, 'registerSubmit'])->name('register.post.index');
Route::post('/login', [AuthController::class, 'loginSubmit'])->name('login.post.index');
Route::post('/logout', [AuthController::class, 'logoutSubmit'])->name('logout.post.index');
Route::post('/ai-question', [OpenAIController::class, 'OpenAIChatBot'])->name('sender');