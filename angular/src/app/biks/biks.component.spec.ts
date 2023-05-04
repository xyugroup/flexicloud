import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BiksComponent } from './biks.component';

describe('BiksComponent', () => {
  let component: BiksComponent;
  let fixture: ComponentFixture<BiksComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ BiksComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(BiksComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
