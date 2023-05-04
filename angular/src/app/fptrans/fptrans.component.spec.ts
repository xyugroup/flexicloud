import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FptransComponent } from './fptrans.component';

describe('FptransComponent', () => {
  let component: FptransComponent;
  let fixture: ComponentFixture<FptransComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FptransComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(FptransComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
